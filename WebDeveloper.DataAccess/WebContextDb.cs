using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb : DbContext
    {
        public WebContextDb() : base("WebDeveloperConnectionString")
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }

        public virtual DbSet<BookAuthor> BookAuthor { get; set; }

        public virtual DbSet<Books> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<StateProvince>()
            //    .Property(e => e.StateProvinceCode)
            //    .IsFixedLength();

            //modelBuilder.Entity<StateProvince>()
            //    .HasMany(e => e.Address)
            //    .WithRequired(e => e.StateProvince)
            //    .WillCascadeOnDelete(false);
        }
    }
}
