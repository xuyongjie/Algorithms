using AlgorithmsImplementation.Common.Map.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.Common.Map.BFS
{
    class ForBFSNode<T>:Node<T>
    {
        public ForBFSNode()
        {
            Parent = null;
            Color = NodeColor.WHITE;
        }
        public ForBFSNode<T> Parent { get; set; }
        public NodeColor Color { get; set; }
    }
}
