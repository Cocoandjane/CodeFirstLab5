using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Province
    {
        [Key]
        public string ProvinceCode { get; set; }

        public string ProvinceName { get; set; }
        [Required]
        public ICollection<City> Cities { get; set; }
    }
}

