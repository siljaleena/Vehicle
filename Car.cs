using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Car : Vehicle
    {
      

        public Car(string aColour, string aManufactorer, int aGaslevel)
        : base(aColour, aManufactorer, aGaslevel)
        {
            colour = aColour;
            manufactorer = aManufactorer;
            gaslevel = aGaslevel;
        }



  
        public void OpenWindow()
        {

            Console.WriteLine("Your window is open.. ahh... fresh air");
        }
        public void OpenRadio()
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Do you want to turn on the radio? yes / no  ");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "yes")
                {
                    Console.WriteLine("You turn on your favourite tunes");
                    validInput = true;
                }
                else if (userInput == "no")
                {
                    Console.WriteLine("You decide to enjoy the sound of your engine");
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
