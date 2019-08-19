using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class clsPath
    {
        public clsNode nodeFrom { get; set; }
        public clsNode nodeTo { get; set; }

        public int pathWeight { get; set; }

        public string fromNode
        {
            get
            {
                return nodeFrom.name;
            }
        }
        public string toNode
        {
            get
            {
                return nodeTo.name;
            }
        }

        public clsPath(clsNode _nodeFrom, clsNode _nodeTo, int _pathWeight)
        {
            nodeFrom = _nodeFrom;
            nodeTo = _nodeTo;
            pathWeight = _pathWeight;
        }

        public clsNode[] GetPath()
        {
            return new clsNode[] { nodeFrom, nodeTo };
        }
    }

}
