using System;
using System.ComponentModel.DataAnnotations;

namespace ProductWEB.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Favor ingrese el nombre del producto")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Favor ingrese la descripción del producto")]
        public string Description { get; set; }
        [Range(1, 100, ErrorMessage ="El precio del producto debe estar en un rango de {1} a {2}")]
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }



    }
}
