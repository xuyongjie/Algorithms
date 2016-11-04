using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.Common.Map
{
    class BFSTest
    {
        private BFS<int> _bfs;
        private ForBFSENode<int> _startNode;
        public BFSTest()
        {
            AdjacencyList<int> adjacencyList = new AdjacencyList<int>();
            ForBFSENode<int> firstHead = new ForBFSENode<int> { Data = 1 };
            _startNode = firstHead;
            ForBFSENode<int> secondHead = new ForBFSENode<int> { Data = 2 };
            ForBFSENode<int> thirdHead = new ForBFSENode<int> { Data = 3 };
            ForBFSENode<int> forthHead = new ForBFSENode<int> { Data = 4 };
            adjacencyList.Nodes.AddRange(new List<ForBFSENode<int>>{ firstHead,secondHead,thirdHead,forthHead});
            adjacencyList.NeighborsList.Add(firstHead, new List<Node<int>> { secondHead, forthHead });
            adjacencyList.NeighborsList.Add(secondHead, new List<Node<int>> { firstHead,thirdHead, forthHead });
            adjacencyList.NeighborsList.Add(thirdHead, new List<Node<int>> { secondHead, forthHead });
            adjacencyList.NeighborsList.Add(forthHead, new List<Node<int>> { firstHead, secondHead, thirdHead });
            _bfs = new BFS<int>(adjacencyList);
        }

        public void DoBFS()
        {
            _bfs.DoSearch(_startNode);
        }
    }
}
