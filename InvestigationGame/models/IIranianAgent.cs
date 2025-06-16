using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{
    internal interface IIranianAgent
    {
        string Name { get; }

        List<ISensor> Weaknesses { get; }

        List<ISensor> Injuries { get; }
    }
}
