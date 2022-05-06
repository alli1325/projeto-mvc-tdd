using DesafioTDD.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioTDD.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Caixa> Caixas { get; set; }
        public DbSet<Extrato> Extratos { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }

    public ApplicationDBContext()
    {
    }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string stringconexao = "server=localhost;port=3306;database=desafiotdd;uid=root;password=root";
        optionsBuilder.UseMySql(stringconexao, ServerVersion.AutoDetect(stringconexao));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>().HasData
            (
                new Administrador 
                {
                    Id = 1,
                    User = "admin",
                    Senha = "admin"
                }
            );

            modelBuilder.Entity<Caixa>().HasData
            (
                new Caixa 
                {
                    Id = 1,
                    Ced100 = 500,
                    Ced50 = 500,
                    Ced20 = 500,
                    Ced10 = 500,
                    Total = (500*100) + (500*50) + (500*20) + (500*10)
                }
            );
            
            modelBuilder.Entity<Cartao>().HasData
            (
                new Cartao 
                {
                    Id = 1,
                    Numero = "1895556789473233",
                    Senha = "1234",
                    Saldo = 5000,
                    Status = true
                },

                new Cartao 
                {
                    Id = 2,
                    Numero = "3567556789473233",
                    Senha = "1234",
                    Saldo = 2000,
                    Status = true
                }
            );



            base.OnModelCreating(modelBuilder);
        }
    }


}