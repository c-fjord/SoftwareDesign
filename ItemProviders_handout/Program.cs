using System;
using System.Collections.Generic;
using PortioningMachine;
using PortioningMachine.ItemProviders;
using PortioningMachine.SystemComponents;
using PortioningMachine.Logger;

namespace ProgramController
{
    class Program
    {   
        static void Main(string[] args)
        {   
            IControlUnit ctrl = new ControlUnit(new ConsoleLogger(), new RoundRobinAlogrithm(), 10);
            IItemProvider provider = new ItemProvider(new GaussianDistribution(20, 2));
            Machine RoundRobinMachine = new Machine(ctrl, provider);
            // RoundRobinMachine.start();

            IControlUnit ctrl1 = new ControlUnit(new ConsoleLogger(), new ItemScoreAlgo(), 10, new SocreFunc());
            IItemProvider provider1 = new ItemProvider(new GaussianDistribution(50, 2));
            Machine ScoreItemMachine = new Machine(ctrl1, provider1);
            ScoreItemMachine.start();
        }
        

    }
}