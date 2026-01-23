var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddLocalization();
builder.Services.AddControllers();
builder.Services.AddLocalStorageServices();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDevExpressBlazor(options =>
{
    options.SizeMode = DevExpress.Blazor.SizeMode.Small;
});
builder.Services.AddMvc();

var app = builder.Build();

string[] supportedCultures = ["en-US", "th-TH", "vi-VN"];
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapControllers();
app.MapStaticAssets();
app.MapRazorComponents<MC.Office.Blazor.Testing.Components.App>()
    .AddInteractiveServerRenderMode()
    .AllowAnonymous();

app.Run();