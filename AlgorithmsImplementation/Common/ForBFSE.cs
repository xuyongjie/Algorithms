using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.Common
{
    class ForBFSE<DataType>
    {
        public ForBFSE()
        {
            Parent = null;
            Color = NodeColor.WHITE;
        }
        public ForBFSE<DataType> Parent { get; set; }
        public NodeColor Color { get; set; }

        public ForBFSV<DataType> Data
        {
            get;set;
        }

        public ForBFSE<DataType> Next
        {
            get;set;
        }
    }

    public enum NodeColor
    {
        WHITE,
        GRAY,
        BLACK
    }
}
