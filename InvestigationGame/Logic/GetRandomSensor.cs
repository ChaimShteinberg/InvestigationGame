using InvestigationGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.Logic
{
    internal class GetRandomSensor
    {
        public static ISensor GetSensor()
        {
            ISensor sensor;

            AudioSensor audioSensor = new AudioSensor("AudioSensor");
            ThermalSensor thermalSensor = new ThermalSensor("ThermalSensor");

            Random random = new Random();
            sensor = random.Next(2) == 0 ? audioSensor : thermalSensor;

            return sensor;
        }
    }
}
