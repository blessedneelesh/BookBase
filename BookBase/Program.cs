using BookBase.Repository.Context;
using BookBase.Repository.Interface;
using BookBase.Repository.Repositories;
using BookBase.Services;
using BookBase.Services.Abstractions;
using BookBase.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRepositoryServices();
builder.Services.AddServices();
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
