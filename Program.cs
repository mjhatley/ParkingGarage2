using System;

namespace BonusLab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Parking Garage!");
            Start();
        }

        public static void Start()
        {
            FindSpot(CarType());
            Again();
        }
        public static Vehicles CarType()
        {
            Console.WriteLine("Wwhat kind of vehicle are you driving today?\nPlease select an option\n" +
                              "1) Motorcycle\n2) Compact Car\n3) Bus");
            if (int.TryParse(Console.ReadLine(), out int input) && input>0 && input <=3)
            {
                if (input==1)
                {
                    return new Motorcycle();
                }
                else if (input ==2)
                {
                    return new Car();
                }
                else
                {
                    return new Bus();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number 1-3.");
                return CarType();
            }

        }
        public static void FindSpot(Vehicles vehicle)
        {
            if (vehicle.Size == 1)
            {


                foreach (Level level in ParkingStructure.Structure)
                {
                    foreach (ParkingSpot spot in level.SpotArray)
                    {
                        if (spot.Open)
                        {
                            spot.Open = false;
                            Console.WriteLine("Your Vehicle is on Level {0} and in spot {1}.", level.FloorNumber , spot.SpotNumber);
                            return;
                        }
                    }
                }
                Console.WriteLine("Sorry there are no open spots");
                return;
            }
            else if (vehicle.Size == 2)
            {
                foreach (Level level in ParkingStructure.Structure)
                {
                    foreach (ParkingSpot spot in level.SpotArray)
                    {
                        if (spot.Open && spot.Size >= 2)
                        {
                            spot.Open = false;
                            Console.WriteLine("Your Vehicle is on Level {0} and in spot {1}.", level.FloorNumber, spot.SpotNumber);
                            return;
                        }
                    }
                }
                Console.WriteLine("Sorry there are no open spots");
                return;
            }
            else 
            {
                foreach (Level level in ParkingStructure.Structure)
                {
                    foreach (ParkingSpot spot in level.SpotArray)
                    {
                        if (spot.Open && spot.Size == 3)
                        {
                            bool inRow = true;
                            int i = spot.SpotNumber;
                            while (inRow == true && i <= spot.SpotNumber + 3)
                            {
                                if (!level.SpotArray[i].Open == true || level.SpotArray[i].Size != 3)
                                {
                                    inRow = false;
                                }
                                if (i == spot.Size + 3)
                                {
                                    Console.WriteLine("Your Vehicle is on Level {0} and in spots {1} - {2}.", level.FloorNumber, spot.SpotNumber, spot.SpotNumber + 4);
                                    return;
                                }
                                i++;
                            }
                        }

                    }
                }
                Console.WriteLine("Sorry there are no open spots");
                return;
            }

        }

        public static void Again()
        {
            Console.WriteLine("Press 'Y' to park another car or any other key to end.");
            string input = Console.ReadLine().ToLower();
            if (input=="y")
            {
                Start();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
