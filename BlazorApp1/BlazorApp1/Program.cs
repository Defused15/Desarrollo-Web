using BlazorApp1.Components;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Servicios de BlazorBootstrap (Toasts, Modal, gráficos...)
builder.Services.AddBlazorBootstrap();

// Base de datos SQLite con Entity Framework Core
builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlite("Data Source=cursos.db"));

var app = builder.Build();

// Aplica las migraciones al arrancar (crea cursos.db si no existe)
using (var scope = app.Services.CreateScope())
{
    using var db = scope.ServiceProvider.GetRequiredService<IDbContextFactory<AppDbContext>>().CreateDbContext();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
// Minimal API (opcional): lista de cursos en JSON
app.MapGet("/api/cursos", async (IDbContextFactory<AppDbContext> f) =>
{
    using var db = await f.CreateDbContextAsync();
    return await db.Cursos.AsNoTracking().ToListAsync();
});

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
