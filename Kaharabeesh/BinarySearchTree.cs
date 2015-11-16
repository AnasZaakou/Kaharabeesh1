using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class BinarySearchTree
    {
        public Node Root { get; set; }

        public class Node
        {
            public int Data { get; set; }
            public Node Right { get; set; }
            public Node Left { get; set; }

            public Node(int _Data)
            {
                this.Data = _Data;
                Right = null;
                Left = null;
            }
        }

        public BinarySearchTree()
        {
            Root = null;
        }

        public Node Insert(int Data, Node Node)
        {
            if (Node == null)
                return new Node(Data);
            else if (Node.Data < Root.Data)
                        Node.Left = Insert(Data, Root.Left);
            else
                    Node.Right = Insert(Data, Root.Right);
            return Node;
        }

        public void Insert(int Data)
        {
            if (Root == null)
                Root = new Node(Data);
            else
            {
                Node Current = Root;
                bool Inserted = false;

                while (!Inserted)
                {
                    if (Data < Root.Data)
                    {
                        if (Current.Left == null)
                        {
                            Current.Left = new Node(Data);
                            Inserted = true;
                        }
                        else
                        {
                            Current = Current.Left;
                        }
                    }
                    else if (Data > Current.Data)
                    {
                        if (Current.Right == null)
                        {
                            Current.Right = new Node(Data);
                            Inserted = true;
                        }
                        else
                        {
                            Current = Current.Right;
                        }
                    }
                }
            }
        }

        public void InOrder(Node Current)
        {
          while (Current != null)
           {
              InOrder(Current.Left);
              Console.WriteLine(Current.Data);
              InOrder(Current.Right);
           }
        }

        public bool IsBalanced(Node Root)
        {
            return (Max(Root) - Min(Root)) > 1;
        }
        private int Max(Node Root)
        {
            if (Root == null)
                return 0;
            else
                return 1 + Math.Max(Max(Root.Left), Max(Root.Right)); 
        }
        private int Min(Node Root)
        {
            if (Root == null)
                return 0;
            else
                return 1 + Math.Min(Min(Root.Left), Min(Root.Right));
        }
    }
}
