using System.Collections.Generic;
using PortioningMachine.ItemProviders;
using PortioningMachine.SystemComponents;
using PortioningMachine.Logger;

namespace PortioningMachine
{
    public class Machine
    {   
        private IItemProvider _provider;
        public Machine(IControlUnit control, IItemProvider provider)
        {
            _provider = provider;
            _provider.ItemArrived += control.item_handler;
        }

        public void start()
        {
           _provider.Go();
        }
    }
}