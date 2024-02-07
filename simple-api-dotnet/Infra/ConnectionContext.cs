using Microsoft.EntityFrameworkCore;
using simple_api_dotnet.Models;

namespace simple_api_dotnet.DataBase
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees => Set<Employee>();
        /*
         *  Conexao em Postgrees 
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgSql(
            "Server=localhost;" +
            "Port=8080;" +
            "User Id="
            );
        */
    }
}
