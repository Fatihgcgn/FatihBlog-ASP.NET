using FatihBlog.Data.Abstract;
using FatihBlog.Data.Concrete;
using FatihBlog.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FatihBlogContext>(options => {
    options.UseSqlite(builder.Configuration["ConnectionStrings:Sql_connection"]);
});

builder.Services.AddScoped<IPostRepository, EfPostRepository>();

var app = builder.Build();


app.UseStaticFiles();


SeedData.TestVerileriniDoldur(app);

app.MapDefaultControllerRoute();

app.Run();