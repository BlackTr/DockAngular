
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

using TodoApi.Models;

namespace backend
{
	public class Startup
	{
		public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
		}
		public IConfigurationRoot Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			// Add framework services.
    		services.AddMvc();

    		services.AddSingleton<ITodoRepository, TodoRepositoryMemory>();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseMvc();

			/*app.Run(async (context) =>
			{
				var ch = Configuration.GetChildren();
				var st = "";
				foreach (var envVar in ch)
				{
					st+= $"{envVar.Key}: {envVar.Value},";
				}
				await context.Response.WriteAsync("Hello World:" + st);
			});*/
		}
	}
}

