using Common.Validations;
using DAL;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services;

namespace Common.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, string connectionstring)
        {
            services.AddDbContext<EmpContext>(a => a.UseSqlServer(connectionstring));
        }
        public static void ConfigureValidations(this IServiceCollection services)
        {
            services.AddSingleton<IValidator, EmployeeValidation>();
            services.AddSingleton<IValidator, SkillValidation>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<EmployeeService>();

        }
    }
}
