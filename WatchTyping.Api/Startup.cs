using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WatchTyping.Infra;

namespace WatchTyping.Api
{
  public class Startup
  {
    private const string CorsPolicyName = "AllowAllOrigins";

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AllowAllCors();
      services.AddWatchTyping();
      services.AddMvc();
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
        app.UseDeveloperExceptionPage();

      app.UseMvcWithDefaultRoute();
      app.UseAllowAllCors();
      app.UseDefaultFiles();
      app.UseStaticFiles();
      app.UseWatchTyping("watchtyping");
    }
  }
}
