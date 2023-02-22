using appdeskperson.DataAccessLayer.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace appdeskperson.DataAccessLayer.Connection
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("connectionString") { }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}