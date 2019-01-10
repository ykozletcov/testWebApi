namespace testWebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using testWebAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<testWebAPI.Models.testWebAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(testWebAPI.Models.testWebAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(p => p.Id,
                new Product() { Id = 1, Category = "Category1", Name = "ProdName1", Price = 10.50M },
                new Product() { Id = 2, Category = "Category2", Name = "ProdName2", Price = 12.98M },
                new Product() { Id = 3, Category = "Category3", Name = "ProdName3", Price = 7.77M }
                );

        }
    }
}
