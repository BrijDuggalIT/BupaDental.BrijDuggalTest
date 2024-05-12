namespace BupaDental.BrijDuggalTest.Data
{
    public class Vehicle
    {
        public string? Registration { get; set; }

        public string? Make { get; set; }

        public string? Model { get; set; }

        public string? PrimaryColour { get; set; }

        public string? ManufactureYear { get; set; }

        public string? FuelType { get; set; }

        public DateTime? MotTestExpiryDate { get; set; }

        public string? MileageOnLastMot { get; set; }

        public List<MotTests> MotTests { get; set; } = new List<MotTests>();

    }
}