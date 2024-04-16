using integracaoLeads2b.Helpers;
using integracaoLeads2b.Interfaces;
using integracaoLeads2b.Persistence;
using integracaoLeads2b.Repository;
using integracaoLeads2b.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Leads");
builder.Services.AddDbContext<LeadsDbContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddScoped<ILeadsService, LeadsService>();
builder.Services.AddScoped<ILeadsRepository, LeadsRepository>();

builder.Services.AddScoped<IOpportunityService, OpportunityService>();
builder.Services.AddScoped<IOpportunityRepository, OpportunityRepository>();

builder.Services.AddScoped<IProspectRepository, ProspectRepository>();
builder.Services.AddScoped<IProspectService, ProspectService>();

builder.Services.AddScoped<IIntegracaoHelper, IntegracaoHelper>();

builder.Services.AddScoped<IHttpRequest, HttpRequestService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
            },
            new string[] { }
        }
    });
});

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
