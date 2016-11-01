using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.Common
{
    class BFS<DataType>
    {
        private AdjacencyList<ForBFSE<DataType>, DataType> _list;
        public BFS(AdjacencyList<ForBFSE<DataType>, DataType> list)
        {
            _list = list;
        }

        public void DoSearch(ForBFSE<DataType> start)
        {
            Queue<ForBFSE<DataType>> queue = new Queue<ForBFSE<DataType>>();
            start.Color = NodeColor.GRAY;
            start.Parent = null;
            queue.Enqueue(start);
            while(queue.Count>0)
            {
                ForBFSE<DataType> item = queue.Dequeue();
                Console.WriteLine(item.Data);
                ForBFSE<DataType> rowHead = GetRowHead(item);
                ForBFSE<DataType> V = rowHead.Next;
                while(V!=null&&V.Color==NodeColor.WHITE)
                {
                    V.Color = NodeColor.GRAY;
                    V.Parent = rowHead;
                    queue.Enqueue(V);
                    V = V.Next;
                }
                rowHead.Color = NodeColor.BLACK;
            }
        }
        
        private ForBFSE<DataType> GetRowHead(ForBFSE<DataType> node)
        {
            foreach(var item in _list._nodes)
            {
                if(item.Data.Equals(node.Data))
                {
                    item.Color = node.Color;
                    return item;
                }
            }
            return null;
        }
    }
}
