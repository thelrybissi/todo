using Microsoft.EntityFrameworkCore;
using Todo.Model;

namespace Todo.Data {

    //Representacao Banco
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        //Representacao Tabela
        public DbSet<TodoModel>? Todos { get; set; }

        //Configuracao Conexa
        
        //protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=localhost,1433;Database=Todo;User ID=sa;Password=1q2w3e4r@#$");
        

    }
}