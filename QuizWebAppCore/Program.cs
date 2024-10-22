using QuizWebAppCore.Data;
using QuizWebAppCore.Repository;
using QuizWebAppCore.Repository.GenericRepository;
using QuizWebAppCore.Repository.RoundRepo;
using QuizWebAppCore.Repository.TeamRepo;
using QuizWebAppCore.Services.Security;
using QuizWebAppCore.Services.TeamServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Service Register (register services BEFORE building the app)
builder.Services.AddSingleton<DapperContext>(); 
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRoundRepository, RoundRepository>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<ITeamService, TeamService>();



builder.Services.AddScoped<ISecurityService, SecurityService>();


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
