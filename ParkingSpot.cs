using System;
namespace BonusLab13
{
    public class ParkingSpot
    { 
        public bool Open { get; set; }
        public int Size { get; set; }
        public int SpotNumber { get; set; }

        //Create parking spot based on availability, size, and spot number
        public ParkingSpot(bool open,int size, int spotNumber )
        {
            this.Open = open;
            this.Size = size;
            this.SpotNumber = spotNumber;
        }
    }
}
