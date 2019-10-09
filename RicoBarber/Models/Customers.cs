using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RicoBarber.Models
{
    [Table("dbo.BarberCustomers")]
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerGender { get; set; }
        public DateTime DateCreated { get; set; }
    }
}