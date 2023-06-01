using Entity.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework
{
    public class RandomDataContext :DbContext
    {
        public DbSet<DynamicModel> MyEntities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           /* optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RandomData;Trusted_Connection=true");*/
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RandomData;Trusted_Connection=true", options =>
            {
                options.EnableRetryOnFailure();
            });
        }
        public void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DynamicModel>()
                .ToTable("DynamicTableName")
                .HasKey(x => x.Id);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            BuildModel(modelBuilder);
        }

    }

}

