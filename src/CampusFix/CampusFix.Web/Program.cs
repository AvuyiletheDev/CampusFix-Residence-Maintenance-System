using CampusFix.Application.Services;
using CampusFix.Domain.Interfaces;
using CampusFix.Infrastructure.Repositories.InMemory;

var builder = WebApplication.CreateBuilder(args);

// Add MVC + API controller support
builder.Services.AddControllersWithViews();

// Add Swagger/OpenAPI support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register repositories from Assignment 11
builder.Services.AddSingleton<IStudentRepository, InMemoryStudentRepository>();
builder.Services.AddSingleton<ITechnicianRepository, InMemoryTechnicianRepository>();
builder.Services.AddSingleton<IMaintenanceRequestRepository, InMemoryMaintenanceRequestRepository>();

// Register services from Assignment 12
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<TechnicianService>();
builder.Services.AddScoped<MaintenanceRequestService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Enable Swagger in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();