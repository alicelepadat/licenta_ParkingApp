namespace ParkingApp.Main.Dtos
{
    public class AdminDto
    {
        public int Id { get; set; }

        public UserDto User { get; set; }

        public ParkingAreaDto ParkingArea { get; set; }
    }
}