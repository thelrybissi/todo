using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

//Adicionando os controllers da aplicação
builder.Services.AddControllers();

//Adicionado os DbContext como serviço -  menos código, sem using
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapControllers();

app.Run();
