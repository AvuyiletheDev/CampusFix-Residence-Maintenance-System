# Branch Protection Rules

## Purpose

Branch protection rules were configured for the `main` branch of the CampusFix repository to ensure that only tested and reviewed code can be merged into the production-ready branch.

## Configured Rules

The following rules were applied to the `main` branch:

- Pull requests are required before merging.
- At least one approval is required before a pull request can be merged.
- Status checks must pass before merging.
- Branches must be up to date before merging.
- Direct uncontrolled changes to the protected branch are restricted.

## Why These Rules Matter

Branch protection improves software quality by preventing untested or incomplete code from being merged directly into the main branch. This supports a professional development workflow where changes are reviewed, tested, and validated before becoming part of the stable application.

For CampusFix, this is important because the system handles student residence maintenance requests, administrator workflows, technician assignments, and API operations. A broken change could affect the reliability of the application.

## Link to Assignment 13

This branch protection setup supports Assignment 13 by enforcing pull request reviews and automated CI checks before code is merged into `main`.