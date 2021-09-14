using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RentalStore.Models
{
    public class RentalStoreContext : DbContext
    {
        public RentalStoreContext():base("name=rentalstore")
        {

           // Database.SetInitializer<RentalStoreContext>(new CreateDatabaseIfNotExists<RentalStoreContext>());

        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<MembershipType> membershipTypes { get; set; }

        public DbSet<Product> products { get; set; }

        public DbSet<TypesOfProduct> TypesOfProducts { get; set; }

    }
}