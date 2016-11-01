using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.Common
{
    /// <summary>
    /// 图的邻接表表示
    /// </summary>
    class AdjacencyList<NodeType,DataType>
    {
        public List<NodeType> E { get; set; }
        public List<NodeType> V { get; set; }
        public AdjacencyList()
        {
            E = new List<NodeType>();
            V = new List<NodeType>();
        }
    }
}
