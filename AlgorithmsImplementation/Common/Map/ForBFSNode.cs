using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.Common.Map
{
    class ForBFSENode<T>:Node<T>
    {
        public ForBFSENode()
        {
            Parent = null;
            Color = NodeColor.WHITE;
        }
        public ForBFSENode<T> Parent { get; set; }
        public NodeColor Color { get; set; }
    }

    public enum NodeColor
    {
        WHITE,
        GRAY,
        BLACK
    }
}
