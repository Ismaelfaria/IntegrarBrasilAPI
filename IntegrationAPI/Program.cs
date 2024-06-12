using IntegrationAPI.Interfaces;
using IntegrationAPI.Mapping;
using IntegrationAPI.Rest;
using IntegrationAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<IAdressService, AdressService>();
builder.Services.AddSingleton<IBankService, BankService>();
builder.Services.AddSingleton<IBrasilApi, BrasilApiRest>();

builder.Services.AddAutoMapper(typeof(AdressMapping));
builder.Services.AddAutoMapper(typeof(BankMapping));

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
