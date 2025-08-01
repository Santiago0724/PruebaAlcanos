using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var conexion = builder.Configuration.GetConnectionString("conexion");
builder.Services.AddDbContext<MyDbContext>(op => op.UseSqlServer(conexion));


builder.Services.AddTransient<ColaRepository>();
builder.Services.AddTransient<MensajesRepository>();

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

app.MapControllers();

app.Run();
