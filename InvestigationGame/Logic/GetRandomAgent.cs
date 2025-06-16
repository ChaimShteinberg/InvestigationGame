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
        public static IIranianAgent GetSensor()
        {
            IIranianAgent sensor;
            List<ISensor> weaknesses = new List<ISensor>();
            List<ISensor> injuries = new List<ISensor>();


            FootSolider footSolider = new FootSolider("AudioSensor", weaknesses, injuries);

            //Random random = new Random();
            //sensor = random.Next() == 0 ? footSolider;

            sensor = footSolider; // זמני

            return sensor;
        }
    }
}
