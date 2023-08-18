using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using presentence.Context;
using presentence.Repository;
//using ServiceLayer.ApplicationUserService;
using ServiceLayer.AssigmentService;
using ServiceLayer.AttendanceService;
using ServiceLayer.CourseService;
using ServiceLayer.SessionService;
using Services.UserService;
using static ServiceLayer.AssigmentService.AssigmentSevice;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
builder.Services.AddControllersWithViews();
//add services for ounion arc
builder.Services.AddMvc();
builder.Services.AddDbContext<PresistanceContext>(options => options
.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddTransient<IApplicationUserService, ApplicationUserService>();
builder.Services.AddTransient<IStudentAssigmentService, StudentAssigmentService>();
builder.Services.AddTransient<ISessionService1, SessionService>();
builder.Services.AddTransient<IAttendanceService, AttendanceService>();
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<IAssigmentService, AssigmentService>();


builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<PresistanceContext>().AddDefaultTokenProviders();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
