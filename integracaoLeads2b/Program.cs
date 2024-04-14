using integracaoLeads2b.Interfaces;
using integracaoLeads2b.Persistence;
using integracaoLeads2b.Repository;
using integracaoLeads2b.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Leads");
builder.Services.AddDbContext<LeadsDbContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddScoped<ILeadsService, LeadsService>();
builder.Services.AddScoped<ILeadsRepository, LeadsRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<LeadsController>();
//builder.Services.AddScoped<LeadsService>();

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
