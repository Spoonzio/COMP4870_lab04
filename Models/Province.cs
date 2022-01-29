using System.ComponentModel.DataAnnotations;

namespace lab4.Models
{
    public class Province
    {

        [Key]
        [MaxLength(30)]
        public String? ProvinceCode { get; set; }
        public string? ProvinceName { get; set; }
        public List<City>? Cities { get; set; }
    }
}
