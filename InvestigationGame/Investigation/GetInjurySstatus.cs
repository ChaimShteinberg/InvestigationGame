using InvestigationGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.Investigation
{
    internal class GetInjurySstatus
    {
        public static int GetStatus(IIranianAgent agent)
        {
            int count = 0;
            foreach (ISensor? sensor in agent.Injuries)
            {
                if (sensor != null)
                {
                    count++;
                }
            }
            return count;            ;
        }
    }
}
