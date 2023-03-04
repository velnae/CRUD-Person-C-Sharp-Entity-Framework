using appdeskperson.DataAccessLayer.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace appdeskperson.DataAccessLayer.Connection
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("connectionString") { }

        public DbSet<PersonNatural> PersonsNatural { get; set; }

        public DbSet<PersonJuridica> PersonsJuridica { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}