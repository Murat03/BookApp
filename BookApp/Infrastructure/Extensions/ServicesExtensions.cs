using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.EFCore;
using Services.Concrete;
using Services.Contracts;

namespace BookApp.Infrastructure.Extensions
{
	public static class ServicesExtensions
	{
		public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<RepositoryContext>(opt =>
			opt.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
		}
		public static void ConfigureRepositoryRegistration(this IServiceCollection services)
		{
			services.AddScoped<IRepositoryManager, RepositoryManager>();
			services.AddScoped<IBookRepository, BookRepository>();
		}
		public static void ConfigureServiceRegistration(this IServiceCollection services)
		{
			services.AddScoped<IServiceManager, ServiceManager>();
			services.AddScoped<IBookService, BookManager>();
		}
	}
}
