using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RicoBarber.Models
{
    [Table("Hairstyles")]
    public class HairstylesModel
    {
        [Key]
        public int Id { get; set; }
        public string HairstyleName { get; set; }
        [ForeignKey("HairstyleId")]
        public List<Customers> MyProperty { get; set; }
    }
}