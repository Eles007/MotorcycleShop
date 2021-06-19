using System.ComponentModel.DataAnnotations;

namespace MotorcycleShop
{
    public class Motorcycle
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), MinLength(5)]
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompanyId { get; set; } //внешний ключ

        public Company Company { get; set; } // навигационное свойство
    }
}
