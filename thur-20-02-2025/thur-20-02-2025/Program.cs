namespace thur_20_02_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brand = "Ford";
            string model = "Fiesta";
            int year = 2000;
            char gearType = 'A';
            double kmStand = 151;
            double kmPerLiter = 15;
            bool isEngineOn = false;

            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Read Car Details \n " +
                                  "2. Drive \n " +
                                  "3. Calculate Trip Price \n " +
                                  "4. IsPalindrome \n " +
                                  "5. Print Car Details \n " +
                                  "6. Print All Team Cars \n " +
                                  "7. Afslut programmet");


                Console.Write("What function do you want to use? ");
                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        ReadCarDetails();
                        break;
                    case 2:
                        Console.Write("Indtast turens distance: ");
                        double distance = double.Parse(Console.ReadLine());
                        Drive(distance);
                        break;
                    case 3:
                        Console.Write("Indtast turens distance: ");
                        double tripDistance = double.Parse(Console.ReadLine());
                        Console.Write("Indtast literpris");
                        double literPrice = double.Parse(Console.ReadLine());
                        CalculateTripPrice(tripDistance, literPrice);
                        break;
                    case 4:
                        isPalindrome();
                        break;
                    case 5:
                        PrintCarDetails();
                        break;
                    case 6:
                        PrintAllTeamCars();
                        break;
                    case 7:
                        running = false;
                        break;
                }
            }

            void ReadCarDetails()
            {
                Console.Write("Indtast bilmærke: ");
                brand = Console.ReadLine();

                Console.Write("Indtast bilmodel: ");
                model = Console.ReadLine();

                Console.Write("Indtast årgang: ");
                year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Indtast geartype: ");
                gearType = Console.ReadLine()[0];

                Console.Write("Indtast km stand: ");
                kmStand = double.Parse(Console.ReadLine());
                
                Console.Write("Indtast km per liter: ");
                kmPerLiter = double.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            void Drive(double distance)
            {
                if (isEngineOn)
                {
                    kmStand += distance;
                }
            }

            double CalculateTripPrice(double distance, double literPrice)
            {
                double tripPrice = 0;
                
                if (literPrice < 0)
                {
                    tripPrice = distance / kmPerLiter * literPrice;
                }

                return tripPrice;
            }

            bool isPalindrome()
            {
                string odometerString = kmStand.ToString();
                int len = odometerString.Length;

                for (int i = 0; i < len / 2; i++)
                {
                    if (odometerString[i] != odometerString[len - i - 1])
                    {
                        Console.WriteLine($"Kilometerstanden på {kmStand} er ikke palindrome");
                        return false;
                    }
                }
                Console.WriteLine($"Kilometerstanden på {kmStand} er palindrome");
                return true;
            }

            void PrintCarDetails()
            {
                double typiskTurDistance = 15;
                
                Console.WriteLine($"Brand: {brand} \n" +
                                  $"Model: {model} \n" +
                                  $"Year: {year} \n" +
                                  $"Gear Type: {gearType} \n" +
                                  $"KM Stand: {kmStand} \n" +
                                  $"KM Per Liter: {kmPerLiter} \n" +
                                  $"En typisk tur på {typiskTurDistance}km vil koste {CalculateTripPrice(typiskTurDistance, 17)}kr med en liter pris på 17kr");
            }

            void PrintAllTeamCars()
            {
                Console.WriteLine("All team cars:)))");
            }
        }
    }
}


