using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the denomination of the Philippine Bank Note (Bills and Coins): ");
    string input = Console.ReadLine();
    
    if (decimal.TryParse(input, out decimal denomination))
        {
            string personality = GetPersonality(denomination);
            if (personality != null)
            {
                Console.WriteLine($"Personality found: {personality}");
            }
          else 
            {
                Console.WriteLine("Invalid Denomination. Please enter a valid denomination.");
            }
        }
        else
        {
            Console.WriteLine($"Invalid input: {input}");
        }
    }
     static string GetPersonality(decimal denomination)
        {
            if (denomination == 0.01m)
            {
                return "No person found";
            }
            else if (denomination == 0.05m)
            {
                return "No person found";
            }
            else if (denomination == 0.25m)
            {
                return "No person found";
            }
            else if (denomination == 1)
            {
                return "Jose Rizal";
            }
            else if (denomination == 5)
            {
                return "Emilio Aguinaldo";
            }
            else if (denomination == 10)
            {
                return "Andres Bonifacio, Apolinario Mabini";
            }
            else if (denomination == 20)
            {
                return "Manuel L. Quezon";
            }
            else if (denomination == 50)
            {
                return "Sergio Osmena";
            }
            else if (denomination == 100)
            {
                return "Manuel Roxas";
            }
            else if (denomination == 200)
            {
                return "Diosdado Macapagal";
            }
            else if (denomination == 500)
            {
                return "Benigno Sr. and Corazon Aquino";
            }
            else if (denomination == 1000)
            {
                return "Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda";
            }
            else
            {
                return null;
            }
    }
}