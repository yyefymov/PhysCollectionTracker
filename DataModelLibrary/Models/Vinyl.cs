namespace DataModelLibrary.Models
{
    public class Vinyl : MusicItemBase
    {
        public VinylSpeed Speed { get; set; }
        public int NumberOfLPs { get; set; }
    }

    public enum VinylSpeed
    {
        RPM33,
        RPM45
    }
}
