using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WatchTyping.Api
{
  public static class CorsConfig
  {
    private const string CorsPolicyName = "AllowAllOrigins";

    public static void AllowAllCors(this IServiceCollection services)
    {
      services.AddCors(options =>
        options.AddPolicy(CorsPolicyName,
            builder =>
              builder
              .AllowAnyMethod()
              .AllowAnyHeader()
              .WithOrigins("http://localhost:5000")));
    }

    public static void UseAllowAllCors(this IApplicationBuilder app)
    {
      app.UseCors(CorsPolicyName);
    }
  }
}
