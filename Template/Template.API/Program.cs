using Template.API.Configuration;
using Template.Application.Configuration;
using Template.DataAccess.Configuration;
using Template.Infrastructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddDataAccess(builder.Configuration)
    .AddInfrastructure()
    .AddApplication()
    .AddAPI();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
    
app.MapControllers();

app.Run();
