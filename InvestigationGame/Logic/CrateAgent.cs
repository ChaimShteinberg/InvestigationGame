using InvestigationGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.Logic
{
    internal class CrateAgent
    {
        public static void CrateNewAgent()
        {
            IIranianAgent agent = GetRandomAgent.GetAgent();
            int num = agent.Weaknesses.Length;
            for (; num > 0; num--)
            {
                agent.Weaknesses[num - 1] = GetRandomSensor.GetSensor();
            }
        }
    }
}
