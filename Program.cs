using Microsoft.EntityFrameworkCore;
using razorweb.models;
//IConfiguration configuration;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
var service=builder.Services;
 //configuration=builder.Configuration;
service.AddDbContext<MyBlogContext>(option =>{
    string ? connectString=builder.Configuration.GetConnectionString("MyBlogContext");
    option.UseSqlServer(connectString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.Run();
