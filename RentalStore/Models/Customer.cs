using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalStore.Models
{
    public class Customer: BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }

        public string EmailId { get; set; }


        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid membershipTypeId { get; set; }
        public virtual MembershipType membershipType { get; set; }

    }
}