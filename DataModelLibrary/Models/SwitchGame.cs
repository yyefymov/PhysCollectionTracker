using System.ComponentModel.DataAnnotations;

namespace DataModelLibrary.Models
{
    public class SwitchGame : CollectionItemBase
    {
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        public string? Description { get; set; }
        public string? Genre { get; set; }
        public string? ESRBRating { get; set; }
        [Range(1, 4)]
        public int NumberOfPlayers { get; set; }
        public bool ProControllerCompatible { get; set; }
    }
}
