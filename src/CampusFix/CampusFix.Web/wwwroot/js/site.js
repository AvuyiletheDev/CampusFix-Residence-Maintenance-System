// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", () => {
  const spinner = '<span class="spinner-border spinner-border-sm me-2" role="status" aria-hidden="true"></span>';
  const welcomeSplash = document.querySelector(".welcome-splash");
  const dashboard = document.querySelector(".student-dashboard");
  const issueForm = document.getElementById("issue-form");
  const requestTableBody = document.getElementById("request-table-body");
  const requestFilters = document.querySelectorAll(".request-filter");
  const clearRequestFilters = document.getElementById("clear-request-filters");
  const requestEmptyMessage = document.getElementById("request-empty-message");
  const openCount = document.getElementById("open-count");

  if (welcomeSplash && dashboard) {
    if (window.sessionStorage.getItem("campusfixWelcomeSeen") === "true") {
      welcomeSplash.remove();
      dashboard.classList.add("dashboard-ready");
      document.documentElement.classList.add("campusfix-welcome-seen");
    } else {
      window.sessionStorage.setItem("campusfixWelcomeSeen", "true");
    }
  }

  document.querySelectorAll(".navbar-brand, .navbar-nav .nav-link").forEach((link) => {
    link.addEventListener("click", (event) => {
      const targetUrl = new URL(link.href, window.location.href);
      const currentUrl = new URL(window.location.href);
      const isSameOrigin = targetUrl.origin === currentUrl.origin;
      const isHomeLink = targetUrl.pathname === "/" || targetUrl.pathname.toLowerCase() === "/home" || targetUrl.pathname.toLowerCase() === "/home/index";

      if (!isSameOrigin || !isHomeLink || event.metaKey || event.ctrlKey || event.shiftKey || event.altKey) {
        return;
      }

      event.preventDefault();
      window.sessionStorage.setItem("campusfixWelcomeSeen", "true");
      document.body.classList.add("page-transitioning");

      window.setTimeout(() => {
        window.location.href = targetUrl.href;
      }, 180);
    });
  });

  const escapeHtml = (value) => value.replace(/[&<>"']/g, (character) => ({
    "&": "&amp;",
    "<": "&lt;",
    ">": "&gt;",
    '"': "&quot;",
    "'": "&#039;"
  }[character]));

  const getPriorityClass = (priority) => {
    if (priority === "High") {
      return "danger";
    }

    if (priority === "Medium") {
      return "warning";
    }

    return "info";
  };

  const setLoading = (button, isLoading) => {
    if (!button) {
      return;
    }

    if (isLoading) {
      button.dataset.originalText = button.textContent.trim();
      button.disabled = true;
      button.setAttribute("aria-busy", "true");
      button.innerHTML = `${spinner}<span>${button.dataset.originalText}</span>`;
      return;
    }

    button.disabled = false;
    button.removeAttribute("aria-busy");
    button.innerHTML = button.dataset.originalText || "Submit Request";
  };

  const applyRequestFilters = () => {
    if (!requestTableBody) {
      return;
    }

    const selectedFilters = Array.from(requestFilters).reduce((filters, filter) => {
      filters[filter.dataset.filter] = filter.value;
      return filters;
    }, {});

    let visibleRows = 0;

    requestTableBody.querySelectorAll("tr").forEach((row) => {
      const isVisible = Object.entries(selectedFilters).every(([key, value]) => {
        return value === "all" || row.dataset[key] === value;
      });

      row.classList.toggle("request-row-hidden", !isVisible);

      if (isVisible) {
        visibleRows += 1;
      }
    });

    requestEmptyMessage?.classList.toggle("d-none", visibleRows > 0);
  };

  requestFilters.forEach((filter) => {
    filter.addEventListener("change", applyRequestFilters);
  });

  clearRequestFilters?.addEventListener("click", () => {
    requestFilters.forEach((filter) => {
      filter.value = "all";
    });
    applyRequestFilters();
  });

  if (issueForm && requestTableBody && openCount) {
    issueForm.addEventListener("submit", (event) => {
      event.preventDefault();

      const submitButton = issueForm.querySelector('button[type="submit"]');
      const formData = new FormData(issueForm);
      const title = String(formData.get("title") || "").trim();
      const location = String(formData.get("location") || "").trim();
      const category = String(formData.get("category") || "Facilities");
      const priority = String(formData.get("priority") || "Medium");

      if (!title || !location) {
        issueForm.classList.add("was-validated");
        return;
      }

      setLoading(submitButton, true);

      window.setTimeout(() => {
        const row = document.createElement("tr");
        row.className = "request-row-new";
        row.dataset.priority = priority;
        row.dataset.date = "today";
        row.dataset.status = "Submitted";
        row.dataset.category = category;
        row.innerHTML = `
          <td>
            <span class="request-title text-truncate">${escapeHtml(title)}</span>
            <span class="request-location text-truncate">${escapeHtml(location)}</span>
          </td>
          <td>${escapeHtml(category)}</td>
          <td><span class="badge text-bg-${getPriorityClass(priority)}">${escapeHtml(priority)}</span></td>
          <td><span class="badge text-bg-secondary">Submitted</span></td>
          <td>Just now</td>
        `;

        requestTableBody.prepend(row);
        openCount.textContent = String(Number(openCount.textContent) + 1);
        applyRequestFilters();
        issueForm.reset();
        issueForm.classList.remove("was-validated");
        setLoading(submitButton, false);

        const modalElement = document.getElementById("issueModal");
        const modal = window.bootstrap.Modal.getOrCreateInstance(modalElement);
        modal.hide();
      }, 350);
    });
  }

  document.querySelectorAll("form:not([data-client-form='true'])").forEach((form) => {
    form.addEventListener("submit", () => {
      const submitButton = form.querySelector('button[type="submit"], input[type="submit"]');

      if (!submitButton || submitButton.disabled) {
        return;
      }

      if (submitButton.tagName === "INPUT") {
        submitButton.disabled = true;
        submitButton.value = "Submitting...";
        return;
      }

      setLoading(submitButton, true);
    });
  });
});
