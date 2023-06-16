using CollectibleAdderLibrary.Interfaces;
using CollectibleAdderLibrary.Impl;
using DataModelLibrary.Models;
using EFDataHandlerLibrary.Data;
using EFDataHandlerLibrary.Repositories;
using DataModelLibrary.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSqlite<CollectionContext>("Data Source=MediaCollection.db");

builder.Services.AddScoped(typeof(ICollectionRepository<>), typeof(EFCollectionRepository<>));
//builder.Services.AddScoped<EFCollectionRepository<CD>>();
//builder.Services.AddScoped<EFCollectionRepository<Vinyl>>();

builder.Services.AddTransient<ICollectibleAdder, CollectibleAdder>();


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
