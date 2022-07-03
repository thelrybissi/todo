using Microsoft.EntityFrameworkCore;
using Todo.Model;

namespace Todo.Data {

    //Representacao Banco
    public class AppDbContext : DbContext {

        //Representacao Tabela
        public DbSet<TodoModel> Todos { get; set; }

        //Configuracao Conexao
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=app.db;Cache=Shared");

    }
}