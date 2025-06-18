using InvestigationGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.Models
{
    internal class SquedLeader:IranianAgent
    {
        public SquedLeader(string name) : base(name, 4)
        {
        }

        public override void CounterTurns()
        {
            this.CountTurns++;
            if (this.CountTurns % 10 == 0)
            {
                GetWeaknesses();
                for (int i = 0; i < this.Injuries.Length; i++)
                {
                    Injuries[i] = null;
                }
            }

            if (this.CountTurns % 3 == 0)
            {
                Random random = new Random();
                int index = random.Next(0, 3);
                Injuries[index] = null;
            }
        }
    }
}
