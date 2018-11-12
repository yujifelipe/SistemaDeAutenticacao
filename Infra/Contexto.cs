using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Infra
{
    public class Contexto : DbContext
    {
        private readonly IConfiguration configuration;

        public Contexto(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DbSet<Login> Login { get; set; }

        private void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = new SqlConnectionStringBuilder()
            {
                DataSource = "YUJIPC",
                InitialCatalog = "SistemaDeAutenticacao",
                IntegratedSecurity = true
            };
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Contexto"));
        }
    }
}
