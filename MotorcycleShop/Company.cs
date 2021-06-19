using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MotorcycleShop
{
    public class Company
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public string Country { get; set; }

        public List<Motorcycle> Motorcycles { get; set; }
    }
}