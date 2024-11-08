using Microsoft.Extensions.Primitives;

namespace AspNetCore.Application.Middlewares
{
    public class CorrelationIdMiddleware(RequestDelegate next)
    {
        const string correlationIdHeaderKey = "X-Correlation-ID";
        public async Task Invoke(HttpContext context, ILogger<CorrelationIdMiddleware> logger)
        {
            string correlationId = Guid.NewGuid().ToString();

            //Request'in header'ında Correlation Id değerinin olup olmadığı kontrol ediliyor
            if(context.Response.Headers.TryGetValue(correlationIdHeaderKey, out StringValues _correlationId))
                correlationId = _correlationId.ToString();
            else
                context.Request.Headers.Add(correlationIdHeaderKey, correlationId);

            //nlog.config dosyasındaki CorrelationId parametresine değer set ediliyor
            NLog.MappedDiagnosticsContext.Set("CorrelationId", correlationId);

            logger.LogDebug("Asp.NET Core Application CorrelationId Log Example");

            //Bütünsel bir izlenebilirlik kazandırabilmek için Correlation Id değeri response'la da ilişkilendiriliyor
            context.Response.OnStarting(async () =>
            {
                if (!context.Response.Headers.TryGetValue(correlationIdHeaderKey, out _))
                    context.Response.Headers.Add(correlationIdHeaderKey, correlationId);
            });

            //Correlation Id değerini sonraki bileşene/middleware'e aktarılıyor
            context.Items["CorrelationId"] = correlationId;

            await next(context);
        }
    }
}
