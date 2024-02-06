using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Motorcycle : Vehicle
    {

        public Motorcycle(string aColour, string aManufactorer, int aGaslevel)
        : base(aColour, aManufactorer, aGaslevel)
        {
            colour = aColour;
            manufactorer = aManufactorer;
            gaslevel = aGaslevel;
        }

        public void PutHelmetOn()
        {

            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Do you want to put on your helmet? yes / no  ");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "yes")
                {
                    Console.WriteLine("Your helmet suits you well");
                    validInput = true;
                }
                else if (userInput == "no")
                {
                    Console.WriteLine("You think you are being cool, however there is nothing cool about dying so you put on your helmet anyways.");
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter yes or no");
                }
            }
        }
    }
}
