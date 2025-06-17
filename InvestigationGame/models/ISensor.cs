using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{
    internal interface ISensor
    {
        public string Name { get; }

        public bool Activate(IIranianAgent agent, int location);

    }
}
