using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBusV1
{
    public enum Actions { Stop, Left, Right };

    public class Action
    {
        public Actions ActionType { get; set; }
        public int Speed { get; set; }
        public int Period { get; set; }
    }
}
