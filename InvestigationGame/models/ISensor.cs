using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.models
{
    public interface ISensor
    {
        string Name { get; }

        int ActivationCount { get; set; }

        public bool Activate(ISensor?[] weaknesses, int location);

    }
}
