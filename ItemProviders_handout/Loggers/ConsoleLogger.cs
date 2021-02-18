using PortioningMachine.SystemComponents;
using PortioningMachine.Logger;
using System;

namespace PortioningMachine.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void item_arrived(IItem item)
        {
            Console.WriteLine("Item arrived\nId: {0} weight: {1}", item.Id, item.Weight);
        }

        public void bin_closed(IBin bin)
        {
            double giveaway = ((bin.weight - bin.target) / bin.target) * 100;
            Console.WriteLine("Bin closed:\nWeight: {0} Target: {1} Giveaway {2} %", bin.weight, bin.target, giveaway);
        }

        public void waste(IItem item)
        {
            Console.WriteLine("Item wasted\nId: {0} weight: {1}", item.Id, item.Weight);
        }
    }
}