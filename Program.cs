using Microsoft.EntityFrameworkCore;
using SportsFacilityManagementAPI.Data;
using SportsFacilityManagementAPI.Repository;
using SportsFacilityManagementAPI.Service;


// CONFIGURACION INICIAL PARA LOS COMPONENTES SWAGGER Y LOS SERVICIOS Y CONTROLLER 
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 21))));


builder.Services.AddScoped<IEspacioDeportivoRepository, EspacioDeportivoRepository>();
builder.Services.AddScoped<IEspacioDeportivoService, EspacioDeportivoService>();

builder.Services.AddScoped<IReservaRepository, ReservaRepository>();

builder.Services.AddScoped<IReservacionService, ReservacionService>();
builder.Services.AddControllers();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();