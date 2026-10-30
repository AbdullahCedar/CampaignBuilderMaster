using DAL.cv_masterdbModel;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using BLL.Services;
using BLL.Interfaces;
using Serilog;
using DAL.aPortalModel;
using PortalApi.Controllers;
using CsvHelper;
using Microsoft.Extensions.DependencyInjection;
using DAL.aPortalContext;
using DAL.effortContext;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("MasterConnection");


builder.Services.AddDbContext<cv_masterdbContext>((serviceProvider,options) =>
{
    var httpContext = serviceProvider.GetService<IHttpContextAccessor>().HttpContext;
    var httpRequest = httpContext.Request;
    var headers = httpContext.Request.Headers;
    string DBName = "";
    if (headers.ContainsKey("db"))
    {
        if (headers.TryGetValue("db", out var DB))
        {
            DBName = DB;
        }
    }
    if (DBName == "Master")
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("MasterConnection"));

        httpContext.Items["constr"] = builder.Configuration.GetConnectionString("MasterConnection");
    }
    else if (DBName == "demodb")
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("democonnection"));

        httpContext.Items["constr"] = builder.Configuration.GetConnectionString("democonnection");
    }
    else if (DBName == "aPortal")
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("AportalConnection"));

        httpContext.Items["constr"] = builder.Configuration.GetConnectionString("AportalConnection");
    }
    else
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("MasterConnection"));

        httpContext.Items["constr"] = builder.Configuration.GetConnectionString("MasterConnection");
    }
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddCors();
builder.Services.AddSignalR();
////////////////////
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});
///////////////////
///
builder.Services.AddDbContext<aPortalContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AportalConnection")));
builder.Services.AddDbContext<effortsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("effortdb")));
builder.Services.AddScoped<IColReportRepository, ColReportRepository>();
builder.Services.AddScoped<ICUL_ReportRepository, CUL_ReportRepository>();
builder.Services.AddScoped<ICUL_ReportService, CUL_ReportService>();
builder.Services.AddScoped<IGooglepayService, GooglePayService>();
builder.Services.AddScoped<IGooglePayRepository, GooglePayRepository>();
//builder.Services.AddHostedService<TimedHostedService>();
builder.Services.AddHttpClient();

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory()) // Set the base path to the application's directory
    .AddJsonFile("appsettings.json") // Load configuration from appsettings.json
    .Build();

var logDirectory = configuration["LogDirectory"]; // Read the log directory path from the configuration

Log.Logger = new LoggerConfiguration()
    .WriteTo.File(Path.Combine(logDirectory, "ApiLog-.log"), rollingInterval: RollingInterval.Day)
    .CreateLogger();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseCors();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    // Other endpoint configurations...
});


app.Run();
