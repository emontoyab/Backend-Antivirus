using Antivirus.config;
using Antivirus.Services;
using AutoMapper;
using Antivirus.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

// Agregar configuración de servicios
builder.Services.AddControllersWithViews();
builder.Services.ConfigureServices(builder.Configuration);
builder.Services.ConfigureJwtAuthentication(builder.Configuration);
builder.Services.ConfigureSwagger();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:5173") // Reemplaza con la URL de tu frontend
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials(); // Permite el uso de credenciales (cookies, etc.)
    });
});

var app = builder.Build();

// Middleware de manejo de errores
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Antivirus V1");
    c.RoutePrefix = string.Empty; 
});

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Usa la política de CORS
app.UseCors("AllowFrontend");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();