using MyAkademiECommerce.Order.Application.Features.CQRS.Handlers;
using MyAkademiECommerce.Order.Application.Features.Mediator.Handlers;
using MyAkademiECommerce.Order.Application.Interfaces;
using MyAkademiECommerce.Order.Persistence.Context;
using MyAkademiECommerce.Order.Persistence.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblyContaining<GetOrderingQueryHandler>();

});

builder.Services.AddScoped<GetAddressQueryHandler>();
builder.Services.AddDbContext<OrderContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));



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
