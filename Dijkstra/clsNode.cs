using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class clsNode
    {
        public string name { get; set; }
        public int? orderOfLabelling { get; set; }
        public int workingValue { get; set; }

        public clsNode(string _name)
        {
            name = _name;
            orderOfLabelling = null;
            workingValue = int.MaxValue;
        }

        public void Reset()
        {
            orderOfLabelling = null;
            workingValue = int.MaxValue;
        }
    }
}
