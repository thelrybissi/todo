using Microsoft.EntityFrameworkCore;
using Todo.Model;

namespace Todo.Data {

    //Representacao Banco
    public class AppDbContext : DbContext {

        //Representacao Tabela
        public DbSet<TodoModel>? Todos { get; set; }

        //Configuracao Conexao
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=tcp:dev-proj-server.database.windows.net,1433;Database=devProjDB;User ID=devProjUser;Password=s5D66XF#nO4G");

    }
}