namespace DataModelLibrary.Models
{
    public class MusicItemBase : CollectionItemBase
    {
        public string? Artist { get; set; }
        public string? Label { get; set; }
        public int YearOfRecording { get; set; }
        public string? ManufacturerCountry { get; set; }
        public string? Tracklist { get; set; }
    }
}
