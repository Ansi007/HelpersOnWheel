using HOW.Models.Interfaces;
using HOW.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IAnswerRepository, AnswerRepository>();
builder.Services.AddSingleton<IHelperRepository, HelperRepositry>();
builder.Services.AddSingleton<IQuestionRepository, QuestionRepository>();
builder.Services.AddSingleton<ISeekerRepository, SeekerRepositry>();

builder.Services.AddDistributedMemoryCache();//New
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromMinutes(500);
});



//New
/*
 option =>
{
    option.IdleTimeout = TimeSpan.FromSeconds(5);
}
*/
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
app.UseSession();   //New
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
