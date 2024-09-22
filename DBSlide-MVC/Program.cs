using DBSlide_Common.Repositories;
using DAL = DBSlide_DAL;
using BLL = DBSlide_BLL;
using DBSlide_MVC.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Session
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<SessionManager>();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.Cookie.Name = "DBSlideSession";
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.IdleTimeout = TimeSpan.FromMinutes(5);
});
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
    options.Secure = CookieSecurePolicy.Always;
});

// Injection dépendances
builder.Services.AddScoped<IStudentRepository<DAL.Entities.Student>, DAL.Services.StudentService>();
builder.Services.AddScoped<IStudentRepository<BLL.Entities.Student>, BLL.Services.StudentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Session
app.UseSession();
app.UseCookiePolicy();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
