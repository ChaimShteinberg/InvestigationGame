using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{
    internal class FootSolider : IIranianAgent
    {
        public string Name { get; }

        public ISensor?[] Weaknesses { get; } = new ISensor?[2];

        public ISensor?[] Injuries { get; set; } = new ISensor?[2];

        public FootSolider(string name)
        {
            this.Name = name;
        }
    }
}
