﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{
    internal class AudioSensor:ISensor
    {
        public string Name { get; set; }

        public int ActivationCount { get; set; }

        public AudioSensor(string name)
        {
            this.Name = name;
            this.ActivationCount = 0;
        }

        public bool Activate(ISensor?[] weaknesses, int location)
        {
            ActivationCount++;

            if (weaknesses[location] is AudioSensor)
            {
                return true;

            }
            return false;
        }
    }
}
