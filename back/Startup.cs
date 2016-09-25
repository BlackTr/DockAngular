
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace backend
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.Run(async (context) =>
			{
				var config = new ConfigurationBuilder()
					.AddEnvironmentVariables()
					.Build();
				var ch = config.GetChildren();
				var st = "";
				foreach (var envVar in ch)
				{
					st+= $"{envVar.Key}: {envVar.Value},";
				}
				await context.Response.WriteAsync("Hello World!!:" + st);
			});
		}
	}
}

