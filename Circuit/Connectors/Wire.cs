using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuit
{
    class Wire
    {
        public void linkComponents(CircuitComponent first, CircuitComponent second)
        {
            first.pos_terminal.Add(second);
            second.neg_terminal.Add(first);
        }
    }
}
