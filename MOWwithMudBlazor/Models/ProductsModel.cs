using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOWwithMudBlazor.Models
{
    public class ProductsModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]        
        public decimal Price { get; set; }
        [Required]
        public string RAM { get; set; }
        [Required]
        public string HardDisk { get; set; }
        public string Color { get; set; }
        [Required]
        public string GraphicCard { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public string ImagePath { get; set; }
        public CompaniesModel Company { get; set; }



    }
}
