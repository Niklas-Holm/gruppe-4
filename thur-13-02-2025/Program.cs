namespace thur_13_02_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input & string variables


            //Det er Sylwesters nye branch


            Console.WriteLine("Input brand");
            string? brand = Console.ReadLine();

            Console.WriteLine("Input Model");
            string? model = Console.ReadLine();

            Console.WriteLine("Input year");
            int? year = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Input Gear Type (A or M)");
            char? gearType = (Console.ReadLine()[0]);

            Console.WriteLine("Input fuel type (Benzin, Diesel or Electric)");
            string fuelType = Console.ReadLine().ToLower();

            Console.WriteLine("Input km/L");
            double kmPerL = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input current mileage");
            double mileage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input length of journey (in km)");
            double distance = Convert.ToDouble(Console.ReadLine());

            mileage += distance;

            //Declare fuel price
            double fuelPrice = 0.0;

            //If statement to set fuel price
            if (fuelType.ToLower() == "benzin")
            {
                fuelPrice = 13.49;
            }
            else if (fuelType.ToLower() == "diesel")
            {
                fuelPrice = 12.29;
            }
            else if (fuelType.ToLower() == "electric")
            {
                fuelPrice = 10;
            }
            else //Default for invalid input
            {
                Console.WriteLine("Invalid input, defaulting to Benzin price.");
                fuelPrice = 13.49;
            }

            //Fuel needed and trip cost calculations
            double fuelNeeded = distance / kmPerL;
            double tripCost = fuelNeeded * fuelPrice;


            //Format string output setup
            string carInfo = String.Format("Your car information:\n Brand: {0} \n Model: {1} \n Year: {2} \n Gear Type: {3} \n Fuel Type: {4} \n Fuel Efficiency: " +
                                           "{5} km/L \n New Mileage: {6} km \n Journey Distance: {7} km \n Fuel Needed: {8}L \n Trip Cost: {9}DKK",
                                            brand, model, year, gearType, fuelType, kmPerL, mileage, distance, fuelNeeded, tripCost);

            //Output:
            Console.WriteLine(carInfo);

            //Table setup.
            //{0, -10} places "Brand" 10 characters to the left (due to negative value).
            string header = String.Format("\n{0, -10} | {1, -10} | {2, -10}", "Brand", "Model", "Mileage");
            string lineSeparator = new string('-', 33);
            string carBasicInfo = String.Format("{0, -10} | {1, -10} | {2, -10}", brand, model, mileage);

            Console.WriteLine(header);
            Console.WriteLine(lineSeparator);
            Console.WriteLine(carBasicInfo);

            //Enter to exit
            Console.ReadLine();
        }
    }
}
