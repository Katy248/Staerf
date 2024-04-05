using Staerf.App.Components;
using Staerf.App.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<SongsRepository>();

builder.Services.AddLocalization(options => { options.ResourcesPath = "Resources"; });
// builder.Services.AddPortableObjectLocalization(options => options.ResourcesPath = "Localization");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.UseRequestLocalization(new RequestLocalizationOptions()
    .AddSupportedCultures(new[] { "en-US", "ru-RU" })
    .AddSupportedUICultures(new[] { "en-US", "ru-RU" }));

app.MapRazorComponents<Staerf.App.App>()
    .AddInteractiveServerRenderMode();

app.Run();
