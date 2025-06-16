using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{
    internal class AudioSensor:ISensor
    {
        public string Name { get; set; }

        public AudioSensor(string name)
        {
            this.Name = name;
        }
    }
}
