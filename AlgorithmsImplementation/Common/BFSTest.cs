using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.Common
{
    class BFSTest
    {
        private BFS<int> _bfs;
        private ForBFSE<int> _startNode;
        public BFSTest()
        {
            AdjacencyList<ForBFSE<int>, int> adjacencyList = new AdjacencyList<ForBFSE<int>, int>();
            ForBFSE<int> firstHead = new ForBFSE<int> { Data = 1 };
            _startNode = firstHead;
            firstHead.Next = new ForBFSE<int> { Data = 2 };
            firstHead.Next.Next = new ForBFSE<int> { Data = 3 };
            firstHead.Next.Next.Next = new ForBFSE<int> { Data = 4 };
            adjacencyList._nodes.Add(firstHead);
            ForBFSE<int> secondHead = new ForBFSE<int> { Data = 2 };
            secondHead.Next = new ForBFSE<int> { Data = 1 };
            secondHead.Next.Next = new ForBFSE<int> { Data = 3 };
            adjacencyList._nodes.Add(secondHead);
            ForBFSE<int> thirdHead = new ForBFSE<int> { Data = 3 };
            thirdHead.Next = new ForBFSE<int> { Data = 1 };
            thirdHead.Next.Next = new ForBFSE<int> { Data = 2 };
            thirdHead.Next.Next.Next = new ForBFSE<int> { Data = 4 };
            adjacencyList._nodes.Add(thirdHead);
            ForBFSE<int> forthHead = new ForBFSE<int> { Data = 4 };
            forthHead.Next = new ForBFSE<int> { Data = 1 };
            forthHead.Next.Next = new ForBFSE<int> { Data = 3 };
            adjacencyList._nodes.Add(forthHead);
            _bfs = new BFS<int>(adjacencyList);
        }

        public void DoBFS()
        {
            _bfs.DoSearch(_startNode);
        }
    }
}
