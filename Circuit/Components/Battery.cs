using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuit
{
    class Battery : CircuitComponent
    {
        public Battery()
        {
            voltage = 0;
            name = "battery_" + instance.ToString();
            pos_terminal = null;
            neg_terminal = null;

            instance++;
        }

        public Battery(double voltage)
        {
            this.voltage = voltage;
            name = "battery_" + instance.ToString();
            pos_terminal = null;
            neg_terminal = null;

            instance++;
        }

        public override void setVoltage(double voltage)
        {
            this.voltage = voltage;
        }

        public override void setCurrent(double current)
        {
            throw new NotImplementedException();
        }

        private static int instance = 0;
    }
}
