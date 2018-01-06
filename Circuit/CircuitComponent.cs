using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuit
{
    abstract class CircuitComponent
    {
        public void setName(string name) { this.name = name; }
        public abstract void setVoltage(double voltage);
        public abstract void setCurrent(double current);

        public string getName() { return name; }
        public double getVoltage() { return voltage; }
        public double getCurrent() { return current; }

        public List<CircuitComponent> pos_terminal;
        public List<CircuitComponent> neg_terminal;

        protected string name;
        protected double voltage;
        protected double current;
    }
}
