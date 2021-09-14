using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalStore.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public Guid CreatedBy{ get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}