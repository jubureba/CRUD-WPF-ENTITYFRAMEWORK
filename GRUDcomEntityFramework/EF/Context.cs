using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GRUDcomEntityFramework.EF
{
    class Context : DbContext
    {
        //Contrutor passando a ConnectionString
        public Context() : base("Register"){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Users> Users { set; get; }

    }
}
