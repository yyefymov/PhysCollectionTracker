using System.ComponentModel.DataAnnotations;

namespace DataModelLibrary.Models
{
    public class CollectionItemBase
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public int YearOfProduction { get; set; }
    }
}
