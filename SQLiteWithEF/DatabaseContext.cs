using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;

namespace SQLiteWithEF
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = "D:\\Database\\EmployeeDB.db",
                ForeignKeys = true
            }.ConnectionString
        }, true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<EmployeeMaster> EmployeeMasters { get; set; }
    }
}
