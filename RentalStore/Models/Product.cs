using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalStore.Models
{
    public class Product:BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid TypesOfProductId{ get; set; }
        public virtual TypesOfProduct TypesOfProduct { get; set; }
    }
}