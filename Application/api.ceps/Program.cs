using api.ceps.Services;
using System.Reflection;

namespace api.ceps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Esta seria forma mais correta, permitindo exatamente a origem (no caso o endereço do front).
			//builder.Services.AddCors(c =>
			//{
			//	c.AddPolicy("cepCors", options => options.WithOrigins("https://localhost:7282").AllowAnyMethod().AllowAnyHeader());
			//});

			builder.Services.AddCors(c => 
            {
                c.AddPolicy("cepCors", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

			// Add services to the container.
			builder.Services.AddSingleton<ICepService,CepService>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }           

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("cepCors");
            app.MapControllers();

            app.Run();
        }
    }
}