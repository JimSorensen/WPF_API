using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WPF_RestfulAPI.Model;
using WPF_RestfulAPI.Services;

namespace WPF_RestfulAPI
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<APIDbContext>(options =>
			options.UseMySql(
					Configuration.GetConnectionString("DefaultConnection"),
					ServerVersion.AutoDetect(Configuration.GetConnectionString("DefaultConnection"))));

			services.AddTransient<DepartmentService>();
			services.AddTransient<PersonDetailService>();
			services.AddTransient<PersonService>();
			services.AddTransient<PositionService>();
			services.AddTransient<SalaryService>();

			services.AddControllers();

			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "WPF_RestfulAPI", Version = "v1" });
			});
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WPF_RestfulAPI v1"));
			}
			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}

#region Link til Udemy video

/* https://www.udemy.com/course/the-complete-guide-to-aspnet-web-api/learn/lecture/
 *
 https://www.udemy.com/course/c-restful-api-and-wpf-core-with-mssql-ef-core/learn/lecture/
 */

#endregion Link til Udemy video