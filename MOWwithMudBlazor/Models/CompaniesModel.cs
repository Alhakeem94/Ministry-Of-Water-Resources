using System.ComponentModel.DataAnnotations;

namespace MOWwithMudBlazor.Models
{
    public class CompaniesModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

    }
}
