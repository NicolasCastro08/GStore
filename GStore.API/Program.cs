using System.ComponentModel;
using System.Text;
using Google.Protobuf.WellKnownTypes;
using GStore.API.Data;
using GStore.API.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Serviço de Conexão com o Banco
string conexao = builder.Configuration.GetConnectionString("Conexao");
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseMySQL(conexao)
);

// Serviço de Autenticação e Autorização - Identity
builder.Services.AddIdentity<Usuario, IdentityRole>(options =>
{
    // Configurar Senha 
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 0;

    // Configurar Bloqueio
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);

    // Configurar Usuário
    options.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

// Serviços JWT
var jwtSettings = builder.Configuration.GetSection("JwtSetting");
var secretKey = jwtSettings["SecretKey"];

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
    };
});

// Configuração do serviço de autorização
builder.Services.AddAuthorization();

// Configuração dos serviços customizados


// Configuração do CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader(); 
    });
});

// Configuração do Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
       PageTitle = "GStore API",
       Version = "v1",
       Description = "API de fornecimento de dados de produtos" 
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            }, new string[]{}
        }
    });
});


builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Garantir que o banco exista ao executar
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await db.Database.EnsureCreatedAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Palmeiras Store v1");
        c.RoutePrefix = string.Empty;
    });
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseStaticFiles(); //

app.UseAuthorization();

app.MapControllers();

app.Run();
