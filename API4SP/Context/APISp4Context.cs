using API4SP.Domains;
using Microsoft.EntityFrameworkCore;

namespace API4SP.Context
{
    public class APISp4Context : DbContext
    {
        public DbSet<Product> Product { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE14-S21\\MSSQLSERVER1; Database = DbSP4; User Id = SA; Pwd = Senai@134; TrustServerCertificate = true;");
        }
    }
}
