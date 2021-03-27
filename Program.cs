using System;

namespace deliverable_one
{
    class Program
    {
        static void Main(string[] args)

        {
        Restart:
            Console.Write("Please enter a measurement type: ");
            string userInput = Console.ReadLine();

            Console.Write("Please enter a numerical amount: ");
            string userInput2 = Console.ReadLine();
            double amount = double.Parse(userInput2);

            if (userInput.ToLower() == "inch")
            {
                double inchConversion = 3.5 * amount;

                Console.WriteLine($" { userInput2 } inch(es) is equivalent to { inchConversion } fidget spinners.");
                //Console.Write("This is" + inchConversion.ToString() + " in fitdget spinners");
                //Console.Write("This is " + inchConversion + " in fidget spinners");
                //Console.Write($"This is { 3.5 * amount } in fidget spinners");
            }
            else if (userInput.ToLower() == "fidget spinners")
            {
                double fidgetSpinnersConversion = amount / 3.5;

                Console.WriteLine($" { userInput2 } fidget spinner(s) is equivalent to { fidgetSpinnersConversion } inches.");
            }
            else if (userInput.ToLower() == "feet")
            {
                double feetConversion = 5 * amount;

                Console.WriteLine($" { userInput2 } feet is equivalent to { feetConversion } memes.");
            }
            else if (userInput.ToLower() == "memes")
            {
                double memesConversion = amount / 5;

                Console.WriteLine($"{ userInput2 } meme(s) is equivalent to { memesConversion } feet.");

            }

        
            {
                Console.WriteLine("Would you like to do another calculation? (Y/N) ");
                string userInput3 = Console.ReadLine();

             while (userInput3.ToLower() == "y")
                {
                    Console.WriteLine("Awesome!");
                    goto Restart;
                }
              while (userInput3.ToLower() == "n")
               {
                    Console.Write("Thank you!");
                    break;
               }
            }

            

            
        }
    }
}
