using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Minimals_Apis.Dominio.DTOs;
using Minimals_Apis.Dominio.Infraestrutura.Db.DbContexto;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<DbContexto>(Options=>{
Options.UseSqlServer(
app.Configuration.GetConnectionString("MinhaConexao")
);
});

app.MapGet("/", () => "Hello World!");
app.MapGet("/login",(LoginDTOs loginDTO)=>{
if(loginDTO.Email=="teste@gmail.com" && loginDTO.Senha=="1234"){
    return Results.Ok("Funciona");
}
else
return Results.Unauthorized();
});

app.Run();