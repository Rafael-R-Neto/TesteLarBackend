using Microsoft.EntityFrameworkCore;
using TesteLar.API.Configurations;
using TesteLar.Application.Configurations;
using TesteLar.Infra.Context;
using TesteLar.Infra.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerConfig();

builder.Services.AddDbContext<LarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(AutoMapperConfig).Assembly);

builder.Services.AddServiceInjection();
builder.Services.AddRepositoryInjection();
builder.Services.AddCorsConfiguration();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(option =>
    {
         option.SwaggerEndpoint("/swagger/v1/swagger.json", "TesteLar API V1");
         option.SwaggerEndpoint("/swagger/v2/swagger.json", "TesteLar API V2");
    });
}

app.UseCors("AllowedOrigins");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
