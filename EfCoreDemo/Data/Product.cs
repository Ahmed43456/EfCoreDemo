using System;
using System.ComponentModel.DataAnnotations;

namespace EfCoreDemo.Data
{
    public class Product
    {


        [Required]
        public int Id { get; set; }
       

        [Required]
        public string Name { get; set; }
        [Required]
        public string Color { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
