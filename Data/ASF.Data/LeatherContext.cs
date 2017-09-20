namespace ASF.Data
{
    using ASF.Entities;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class LeatherContext : DbContext
    {
        // Your context has been configured to use a 'LeatherContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ASF.Data.LeatherContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LeatherContext' 
        // connection string in the application configuration file.
        public LeatherContext()
            : base("name=DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>().HasKey(c => c.Id);


            //modelBuilder.Entity<Item>().ToTable("Items");
        }

        public DbSet<Category> Category { get; set; }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }


}