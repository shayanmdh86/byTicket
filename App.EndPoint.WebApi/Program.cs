using App.Domain.AppService.Passenger;
using App.Domain.Core.Passenger.AppService;
using App.Domain.Core.Passenger.Data;
using App.Domain.Core.Passenger.Service;
using App.Domain.Service.Passenger;
using App.Infra.Repo.Ef.Passenger;
using App.Infra.SqlServer.Ef.Dbctx;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<IPassengerQueryRepoEf, PassengerQueryRepoEf>();
builder.Services.AddScoped<IPassengerService, PassengerService>();
builder.Services.AddScoped<IPassengerAppService, PassengerAppService>();


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
