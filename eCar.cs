using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class eCar : Vehicle
    {

        public eCar(string aColour, string aManufactorer, int aGaslevel)
        : base(aColour, aManufactorer, aGaslevel)
        {
            colour = aColour;
            manufactorer = aManufactorer;
            gaslevel = aGaslevel;
        }

        public override void Drive()
        {
            Console.WriteLine("Motor is running, ssshhhhhhhh!");
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
    }
}
