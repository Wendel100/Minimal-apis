using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        var ConexaoString = _configuration.GetConnectionString("MinhaConexao").ToString();
        if(!string.IsNullOrEmpty(ConexaoString)){
        optionsBuilder.UseSqlServer("MinhaConexao");
            }

        }
        }
    }