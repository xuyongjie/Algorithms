using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.Common.Map
{
    class BFS<DataType>
    {
        private AdjacencyList<DataType> _list;
        public BFS(AdjacencyList<DataType> list)
        {
            _list = list;
        }

        public void DoSearch(ForBFSENode<DataType> start)
        {
            Queue<ForBFSENode<DataType>> queue = new Queue<ForBFSENode<DataType>>();
            start.Color = NodeColor.GRAY;
            start.Parent = null;
            queue.Enqueue(start);
            while(queue.Count>0)
            {
                ForBFSENode<DataType> item = queue.Dequeue();
                Console.WriteLine("node {0},parent is {1}",item.Data,item.Parent==null?"null": item.Parent.Data.ToString());
                foreach(var each in _list.NeighborsList[item])
                {
                    ForBFSENode<DataType> bfsNode = (ForBFSENode<DataType>)each;
                    if(bfsNode.Color==NodeColor.WHITE)
                    {
                        bfsNode.Color = NodeColor.GRAY;
                        bfsNode.Parent = item;
                        queue.Enqueue(bfsNode);
                    }
                }
                item.Color = NodeColor.BLACK;
            }
        }

    }
}
