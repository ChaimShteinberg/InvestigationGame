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

        ISensor?[] Weaknesses { get; }

        ISensor?[] Injuries { get; set; }
    }
}
