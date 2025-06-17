using InvestigationGame.Logic;
using InvestigationGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.Investigation
{
    internal class InvestigationManager
    {
        public static void Investigation()
        {
            Console.WriteLine("Welcome to Investigation Game!");

            
            IIranianAgent agent = CreateAgent.CreateNewAgent();

            while (true)
            {

                int location = SelectLocation.Select(agent.Weaknesses.Length);

                ISensor sensor = AttachingSensor.Attaching();

                bool test = sensor.Activate(agent, location);

                if (test)
                {
                    agent.Injuries[location] = sensor;
                }

                int injuries = GetInjurySstatus.GetStatus(agent);

                ShowStatus.Show(agent, injuries);

                if (injuries == agent.Injuries.Length)
                {
                    Console.WriteLine("Iranian agent exposed!");
                    return;
                }
            }
        }
    }
}
