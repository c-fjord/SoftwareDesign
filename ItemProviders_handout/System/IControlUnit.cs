using System.Collections.Generic;

namespace PortioningMachine.SystemComponents
{
    public interface IControlUnit
    {
        void item_handler(object source, IItem item);
    }
}