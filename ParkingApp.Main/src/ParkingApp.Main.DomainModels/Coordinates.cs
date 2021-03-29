namespace ParkingApp.Main.DomainModels
{
    public class Coordinates : BaseEntity
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Address Address { get; set; }
    }
}