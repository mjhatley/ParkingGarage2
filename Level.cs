using System;
namespace BonusLab13
{
    public class Level
    {
        public ParkingSpot[] SpotArray { get; set; }
        public int FloorNumber { get; set; }
        public Level(int number)
        {
            //This adds parking spots to level and tells if parking spot is taken, the size of the parking spot, and the parking spot number
            SpotArray = new ParkingSpot[] {
                new ParkingSpot(true, 1, 1),
                new ParkingSpot(true, 1, 2),
                new ParkingSpot(true, 2, 3),
                new ParkingSpot(true, 2, 4),
                new ParkingSpot(true, 2, 5),
                new ParkingSpot(true, 3, 6),
                new ParkingSpot(true, 3, 7),
                new ParkingSpot(true, 3, 8),
                new ParkingSpot(true, 3, 9),
                new ParkingSpot(true, 3, 10)};
            this.FloorNumber = number;
        }
    }
}
