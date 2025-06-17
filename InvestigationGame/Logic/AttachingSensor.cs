using InvestigationGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.Logic
{
    internal class AttachingSensor
    {
        public static ISensor Attaching()
        {
            while (true)
            {
                Console.Write("Select the sensor you want to pair: ");
                string? select = Console.ReadLine();
                switch (select)
                {
                    case "Audio":
                        AudioSensor audioSensor = new AudioSensor(select);
                        return audioSensor;

                    case "Thermal":
                        ThermalSensor thermalSensor = new ThermalSensor(select);
                        return thermalSensor;

                    default:
                        Console.WriteLine("error select \n" +
                            "try egain");
                        break;
                }
            }          
        }
    }
}
