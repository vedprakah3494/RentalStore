using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalStore.Models
{
    public class MembershipType:BaseEntity
    {
        [StringLength(100)]
        public string Name { get; set; }
        public string Desciption { get; set; }
        public int TimeDuration { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
    }
}