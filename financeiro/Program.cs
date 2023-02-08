using financeiro.Repositorio;
using financeiro.Repositorio.models;
using financeiro.Service;
using financeiro.Service.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<financeiroDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services.AddScoped<IControleDeContasRepositorio, ControleDeContasRepositorio>();
builder.Services.AddScoped<IControleDeContasService, ControleDeContasService>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();

app.Run();
