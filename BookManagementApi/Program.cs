using BookManagementApi.Services.Database;
using Microsoft.EntityFrameworkCore;
using Model.LibraryModel;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<LibraryDbContext>(options =>
{
    options.UseSqlite("Data Source=library.db", dbContextOptions =>
    {
        dbContextOptions.MigrationsAssembly(typeof(LibraryDbContext).Assembly.FullName);
    });

    options.EnableDetailedErrors();
});

builder.Services.AddSingleton<DbInitializer>();
builder.Services.AddHostedService(sp => sp.GetRequiredService<DbInitializer>());

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();