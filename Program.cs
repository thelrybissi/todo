using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

//Adicionando os controllers da aplicação
builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); 
//Adicionado os DbContext como serviço -  menos código, sem using
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

//Adicionando o Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
