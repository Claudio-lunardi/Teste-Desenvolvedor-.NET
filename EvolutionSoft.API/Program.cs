using EvolutionSoft.Infra.Entity;
using EvolutionSoft.Negocio.ContatoNegocio;
using EvolutionSoft.Negocio.PessoaNegocio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<EntityContext>(options => options.UseSqlServer(connection));

builder.Services.AddScoped<IPessoaNegocio, PessoaNegocio>();
builder.Services.AddScoped<IContatoNegocio, ContatoNegocio>();




builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
