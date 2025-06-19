using InvestigationGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.Models
{
    internal class OrganizationLeador:IranianAgent
    {
        public OrganizationLeador(string name) : base(name, 8)
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
                for (int i = 0; i < Injuries.Length; i++)
                {
                    if (Injuries[i] != null)
                    {
                        Injuries[i] = null;
                    }
                }
            }
        }
    }
}
