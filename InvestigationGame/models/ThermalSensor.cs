using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{
    internal class ThermalSensor:ISensor
    {
        public string Name { get; set; }

        public ThermalSensor(string name)
        {
            this.Name = name;
        }

        public bool Activate(IIranianAgent agent, int location)
        {
            if (agent.Weaknesses[location] is ThermalSensor)
            {
                return true;

            }
            return false;
        }
    }
}
