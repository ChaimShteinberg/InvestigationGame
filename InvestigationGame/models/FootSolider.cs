using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{
    internal class FootSolider:IIranianAgent
    {
        public string Name { get; }

        public List<ISensor> Weaknesses { get; }

        public List<ISensor> Injuries { get; }

        public FootSolider(string name, List<ISensor> weaknesses, List<ISensor> injuries)
        {
            this.Name = name;
            this.Weaknesses = weaknesses;
            this.Injuries = injuries;
        }
    }
}
