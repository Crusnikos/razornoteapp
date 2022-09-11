using RazorPagesNoteManagerApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AddPageRoute("/Index/Index", "");
});

var postgresConnection = builder.Configuration.GetConnectionString("MainDatabase");
builder.Services.AddSingleton<Database.Factory>(_ => () => new Database(postgresConnection));

var app = builder.Build();

//Configure the HTTP request pipeline.

Console.WriteLine("Starting the application");
var configuration = app.Services.GetService<IConfiguration>();
if (configuration is null)
{
    throw new ArgumentNullException("Configuration could not be resolved");
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Configuration resolved correctly");
Console.ResetColor();

Console.WriteLine("Start migrations");
var migrator = new Migrator();
await migrator.RunAsync(configuration.GetConnectionString("MainDatabase"));

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
