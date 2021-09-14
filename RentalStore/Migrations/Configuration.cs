namespace RentalStore.Migrations
{
    using RentalStore.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RentalStore.Models.RentalStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RentalStore.Models.RentalStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
           
            context.TypesOfProducts.AddOrUpdate<TypesOfProduct>(new TypesOfProduct() { Id = Guid.NewGuid(), Name = "Book", CreatedDate=DateTime.UtcNow, UpdatedDate=DateTime.UtcNow });
            context.TypesOfProducts.AddOrUpdate<TypesOfProduct>(new TypesOfProduct() { Id = Guid.NewGuid(), Name = "HomeDecoration", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow });
            context.TypesOfProducts.AddOrUpdate<TypesOfProduct>(new TypesOfProduct() { Id = Guid.NewGuid(), Name = "Laptop", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow });
            context.TypesOfProducts.AddOrUpdate<TypesOfProduct>(new TypesOfProduct() { Id = Guid.NewGuid(), Name = "Mobile", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow });
            context.TypesOfProducts.AddOrUpdate<TypesOfProduct>(new TypesOfProduct() { Id = Guid.NewGuid(), Name = "Others", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow });

            context.membershipTypes.AddOrUpdate<MembershipType>(new MembershipType() { Id = Guid.NewGuid(), Name = "Standard Membership", TimeDuration=3, Desciption="Standard Memebership for three Month", Amount=500, Discount=10, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow });
            context.membershipTypes.AddOrUpdate<MembershipType>(new MembershipType() { Id = Guid.NewGuid(), Name = "Standard Plus Membership", TimeDuration = 3, Desciption = "Standard  Plus Memebership for three Month",Amount=1000,Discount=10, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow });

          /// context.customers.AddOrUpdate<Customer>(new Customer() { Id = new Guid(), Name = "Sandeep", EmailId="sandeep@gmail.com",  PhoneNo="9807354073", Password="123", UserName= "sandeep@gmail.com" });


        }
    }
}
