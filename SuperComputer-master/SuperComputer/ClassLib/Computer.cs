using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Computer
    {
        public int rank { get; private set; }
        public string systemName { get; private set; }
        public string computer { get; private set; }
        public string rmax { get; private set; }
        public string rpeak { get; private set; }
        public string power { get; private set; }

        public Computer(int rank, string systemName, string computer,
                        string rmax, string rpeak, string power)
        {
            this.rank = rank;
            this.systemName = systemName;
            this.computer = computer;
            this.rmax = rmax;
            this.rpeak = rpeak;
            this.power = power;
            if (power == "") power = "---";
        }

        public override string ToString() => rank + " " + systemName + " " + computer + " " + rmax + " " + rpeak + " " + power;
    }
}
