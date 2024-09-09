using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using SimpleCRUD.Entities.DBContext;
using SimpleCRUD.Services.Commons.Mapper;
using SimpleCRUD.Services.Customers.Commands;
using SimpleCRUD.Repositories.Interfaces;
using SimpleCRUD.Repositories;

using SimpleCRUD.Services.Customers.Querys;
using GraphQL.Types;
using GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CustomerAssestmentContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("localDb"));
});

// Add AutoMapper
builder.Services.AddAutoMapper(typeof(MapperConfig));

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();


// Register FluentValidation validators
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<CreateCustomerValidation>();

// Add MediatR for CQRS
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateCustomerHandler).Assembly));

// Configure GraphQL
builder.Services.AddGraphQL(b => b
    .AddAutoSchema<CustomerQuery>()  // schema
    .AddSystemTextJson());   // serializer

// Register your GraphQL types and schema
builder.Services.AddScoped<CustomerType>();
builder.Services.AddScoped<CustomerQuery>();
builder.Services.AddScoped<ISchema, GraphQLSchema>();


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

// Configure GraphQL endpoints
app.UseGraphQL<ISchema>("/graphql");
app.UseGraphQLPlayground("/playground");

await using var scope = app.Services.CreateAsyncScope();
await using var db = scope.ServiceProvider.GetService<CustomerAssestmentContext>();
await db.Database.MigrateAsync();

app.Run();
