namespace TruYum
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class truYumContext : DbContext
    {
        
        public truYumContext()
            : base("name=TruYumContext")
        {
        }


        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}