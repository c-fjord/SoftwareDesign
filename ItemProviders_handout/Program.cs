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
            RoundRobinMachine machine = new RoundRobinMachine(10);
            machine.start();
        }
        

    }
}