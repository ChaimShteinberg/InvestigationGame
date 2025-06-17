using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.Investigation
{
    internal class SelectLocation
    {
        public static int Select(int length)
        {
            while (true)
            {
                Console.Write($"Select a location to attach the sensor: (0 - {length - 1}) ");
                string? select = Console.ReadLine();
                if (Int32.TryParse(select, out int value ) && value < length)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("error select \n" +
                        "try egain");
                }
            }
        }
    }
}
