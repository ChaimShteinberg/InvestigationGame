using InvestigationGame.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{
    public abstract class IranianAgent
    {
        public string Name { get; }

        public ISensor?[] Weaknesses { get; }

        public ISensor?[] Injuries { get; set; }

        public int NumSensors { get; set; }

        public int CountTurns = 0;

        public IranianAgent(string name, int numSensors)
        {
            this.Name = name;
            this.NumSensors = numSensors;
            Weaknesses = new ISensor?[NumSensors];
            Injuries = new ISensor?[Weaknesses.Length];
            GetWeaknesses();
        }

        public int GetInjuryStatus()
        {
            CounterTurns();
            int count = 0;
            for (int i = 0; i < Injuries.Length; i++)
            {
                if (Injuries[i] is ISensor)
                {
                    bool test = Injuries[i].Activate(Weaknesses, i);
                    if (test)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public virtual void CounterTurns()
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
        }

        protected void GetWeaknesses()
        {
            for (int i = 0; i < Weaknesses.Length; i++)
            {
                this.Weaknesses[i] = GetRandomSensor.GetSensor();
            }
        }
    }
}
