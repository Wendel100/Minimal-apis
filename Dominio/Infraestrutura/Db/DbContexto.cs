using Microsoft.EntityFrameworkCore;
using Minimals_Apis.Dominio.Entidades;

namespace Minimals_Apis.Dominio.Infraestrutura.Db.DbContexto
{
    public class DbContexto: DbContext
    {
        private readonly IConfiguration _configuration;
        public DbContexto(IConfiguration configuration){
            _configuration = configuration;
        }
        public DbSet<Admininistrador>Admininistradores{get;set;}=default!;

        protected override void OModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admininistrador>().HasData(
                new Admininistrador
                {   Id =1,
                    Email = "Administrador@teste.com",
                    Senha = "123456",
                    Perfil = "Adm"
                }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        var ConexaoString = _configuration.GetConnectionString("MinhaConexao").ToString();
        if(!string.IsNullOrEmpty(ConexaoString)){
        optionsBuilder.UseSqlServer("MinhaConexao");
            }

        }
        }
    }