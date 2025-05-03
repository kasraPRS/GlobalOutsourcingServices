using GlobalOutsourcingServices.Persistance;
using Microsoft.EntityFrameworkCore;

namespace GlobalOutsourcingServices.Configuration
{
    public class Startup
    {
        public IConfiguration _Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add controllers (API)
            services.AddControllers();

            // Add Swagger for API documentation
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            // CORS policy
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });
            // Add AutoMapper
            //services.AddAutoMapper(typeof(Startup));
        }
    }
}
