using Minimals_Apis.Dominio.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/login",(LoginDTOs loginDTO)=>{
if(loginDTO.Email=="teste@gmail.com" && loginDTO.Senha=="1234"){
    return Results.Ok("Funciona");
}
else
return Results.Unauthorized();
});

app.Run();