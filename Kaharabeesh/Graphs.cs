using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class Graphs
    {
        // Q4 BFS
        public static List<LinkedList> Tree2LinkedList(BinarySearchTree.Node Root)
        {
            List<LinkedList> Result;
            if (Root == null)
                return null;
            else
            {
                Result = new List<LinkedList>();
                Queue<BinarySearchTree.Node> Queue = new Queue<BinarySearchTree.Node>();
                Queue<int> QLevels = new Queue<int>();
                Queue.Enqueue(Root);
                QLevels.Enqueue(0);
                Result.Add(new LinkedList());
                Result[0].Add(Root);
                while (Queue.Count != 0)
                {
                    BinarySearchTree.Node TempNode = Queue.Dequeue();
                    LinkedList TempLinkedList;
                    int Level = QLevels.Dequeue();
                    if (TempNode != null)
                    {
                        // Check if(TempNode) is CurrentLevel
                        if (TempNode.Left != null)
                        {
                            Queue.Enqueue(TempNode.Left);
                            QLevels.Enqueue(Level + 1);
                        }
                        if (TempNode.Right != null)
                        {
                            Queue.Enqueue(TempNode.Right);
                            QLevels.Enqueue(Level + 1);
                        }
                        if (Level + 1 != Result.Count)
                        {
                            if (TempNode.Left != null) Result.Last().Add(TempNode.Left);
                            if (TempNode.Right != null) Result.Last().Add(TempNode.Right);
                           
                        }
                        else
                        {
                            TempLinkedList = new LinkedList();
                            if (TempNode.Left != null) TempLinkedList.Add(TempNode.Left);
                            if (TempNode.Right != null) TempLinkedList.Add(TempNode.Right);
                            if (TempNode.Right != null || TempNode.Left != null)
                            Result.Add(TempLinkedList);
                        }
                    }
                }

                return Result;
            }
        }
        // Q5 InOrder
        public static void InOrder(BinarySearchTree.Node Root)
        {
            if (Root == null)
                return;
            InOrder(Root.Left);
            Console.WriteLine(Root.Data);
            InOrder(Root.Right);
        }
        // Q8 Sum of Paths
        public static void SumPath(BinarySearchTree.Node Root)
        {
            // DFS

        }
    }
}
