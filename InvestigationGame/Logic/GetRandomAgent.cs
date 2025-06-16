using InvestigationGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.Logic
{
    internal class GetRandomAgent
    {
        public static IIranianAgent GetAgent()
        {
            IIranianAgent sensor;

            FootSolider footSolider = new FootSolider("AudioSensor");

            //Random random = new Random();
            //sensor = random.Next() == 0 ? footSolider;

            sensor = footSolider; // זמני

            return sensor;
        }
    }
}
