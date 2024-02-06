using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
namespace Testing
{
    public class Vehicle
    {
        public string stopdrive = "no";
        public string drive = "yes";
        public string colour;
        public string manufactorer;
        public int gaslevel = 4; 
        public int nogas = 0;
        public bool outofgas = false;

        public virtual void Drive()
        {

            Console.WriteLine("Motor is running, VROOOM!");

            while (drive != stopdrive && !outofgas)
            {
                if (gaslevel > nogas)
                {
                    Console.WriteLine("You have " + gaslevel + " gas left.");
                    Console.Write("Want to keep driving? yes (Enter) or no (no)?   ");
                    drive = Console.ReadLine();
                    gaslevel--;
                }
                else
                {
                    outofgas = true;
                }
                
            }
            if (outofgas)
            {
                Console.WriteLine("Oh no! You ran out of gas!");
            }
            else
            {
                Console.WriteLine("You decide to stop driving.");
            }
        }

        public Vehicle(string aColour, string aManufactorer, int aGaslevel)
        {
            Console.WriteLine("You are in your " + aColour + aManufactorer);
            colour = aColour;
            manufactorer = aManufactorer;
            gaslevel = aGaslevel;
        }


    }
}