using ApiGetway.Constants;
using ApiGetway.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

// Auth
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = Authentication.Issuer,
        ValidateAudience = true,
        ValidAudience = Authentication.Audience,
        ValidateLifetime = true,
        IssuerSigningKey = Authentication.GetSymmetricSecurityKey(),
        ValidateIssuerSigningKey = true,
    };
});

// Services
builder.Services.AddTransient<ITokenGenerationService, TokenGenerationService>();

// Add Ocelot
IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("OcelotConfig/ocelot.json")
    .Build();

builder.Services.AddOcelot(configuration);


builder.Services.AddControllers();
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
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseOcelot().Wait();
app.Run();