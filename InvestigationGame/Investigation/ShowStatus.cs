using InvestigationGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.Investigation
{
    internal class ShowStatus
    {
        public static void Show(IIranianAgent agent, int injuries)
        {
            Console.WriteLine($"({injuries}/{agent.Injuries.Length}) injuries");
        }
    }
}
