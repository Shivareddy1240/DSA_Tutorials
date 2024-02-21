using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Tutorials.Graph
{
    public class Graph
    {
        private int totalVertex = 0;
        private List<int>[] adjVertex = null;

        public Graph(int size)
        {
            totalVertex = size;
            adjVertex = new List<int>[size];

            //initialize to the size that given
            for(int i=0;i< totalVertex; i++) {
                adjVertex[i] = new List<int>();
            }
        }

        public void AddEdge(int v1,int v2)
        {
            adjVertex[v1].Add(v2);
        }

        public void BFS(int currentvertex)
        {
            //to check we already visited that vertex
            bool[] visitedvertex = new bool[totalVertex];

            Queue<int> queue = new Queue<int>();

            //mark the first vertex as visited
            visitedvertex[currentvertex] = true;

            //add to queue
            queue.Enqueue(currentvertex);

            while(queue.Count !=0)
            {
                currentvertex = queue.Dequeue();

                Console.WriteLine("->" + currentvertex);

                //reading adjacent vertex
                foreach(var nextVertex in adjVertex[currentvertex])
                {
                    //add to the queue

                }
            }
        }

    }

}
