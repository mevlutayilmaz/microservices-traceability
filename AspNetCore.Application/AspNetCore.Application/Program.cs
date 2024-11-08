// Request/Response Traceability'si

using AspNetCore.Application.Middlewares;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

#region NLog Setup
builder.Logging.ClearProviders();
builder.Host.UseNLog();
#endregion

var app = builder.Build();

#region Geliştirilen middleware'leri uygulama papeline'ına dahil etme
app.UseMiddleware<CorrelationIdMiddleware>();
app.UseMiddleware<OtherMiddleware>();
#endregion

app.MapGet("/", (HttpContext context, ILogger<Program> logger) =>
{
    var correlationId = context.Request.Headers["X-Correlation-ID"].FirstOrDefault();
    //ya da
    correlationId = context.Items["CorrelationId"].ToString();

    NLog.MappedDiagnosticsContext.Set("CorrelationId", correlationId);
    logger.LogDebug("Minimal API Log");
});

app.Run();
