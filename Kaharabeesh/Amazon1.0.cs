using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class Amazon1
    {
        /*  1.Document your assumptions
    This is a variation of BFS to traverse the tree level by level. So we need to use a kind of data structure 
    that allows us to print the values level by level (FIFO) which is the Queue.
        a. Added new property to the Node class to hold the value of the level to which it belongs, to ease the printOut 
        of elements at the same level. I could do it by using another data structure to hold the value of the levels 
        like another queue for instance. 
    
    2.Explain your approach and how you intend to solve the problem:
        a. Create Empty Queue to hold nodes in FIFO manner
        b. Start from the root of the tree
        c. Loop while there is at least 1 element in the queue (Count > 0)
            1. Dequeue the first node to 'temp' variable
            2. If the 'temp' level isn't on current level:
                a. Print New Line and Print temp value
                else
                b. Print temp value on current line
            3. Enqueue left of the 'temp' then Enqueue right
    
    4.Explain the big-O run time complexity of your solution. Justify your answer:
    O(n) where n is the number of nodes in the tree as we iterate over the nodes of the tree using the 'while' statement
    and all operations inside the 'while' are O(1) so the main complexity is O(n)
    
    5.Provide a function that calls your printTree() with the provided sample input:
    Provided down.
    
    6.List and describe test cases needed to test your solution (no need to code)
        a. Null/Illegal: null // Passing Null
        b. Extreme: Very small Tree with one element = Node root = new Node(1);
        c. Normal Case: Where we have a set of nodes a, b, c, d, e, f, g

*/
        /*Example input:

            5
           / \
          3   1
        /   / \
        9   4   5
           /
          2
          */
        public class Node
        {
            public int value;
            public Node left;
            public Node right;
            private int level; // 

            public Node(int NodeValue, int Level)
            {
                this.value = NodeValue;
                this.level = Level; // initialize value to 0
            }

            public int Level
            {
                get { return this.level; }
                set { this.level = value; }
            }

            public int Value
            {
                get { return this.value; }
                set { this.value = value; }
            }

            public Node Left
            {
                get { return this.left; }
                set { this.left = value; }
            }

            public Node Right
            {
                get { return this.right; }
                set { this.right = value; }
            }
        }
        public static void main()
        {

            Node a = new Node(5, 0);
            Node b = new Node(3, 1);
            Node c = new Node(1, 1);
            Node d = new Node(9, 2);
            Node e = new Node(4, 2);
            Node f = new Node(5, 2);
            Node g = new Node(2, 3);
            a.Left = b;
            a.Right = c;
            b.Left = d;
            c.Left = e;
            c.Right = f;
            e.Left = g;

            printTree(a);
        }

        // Input: Root of the Tree
        // Output: Printed Tree Level-by-level on Console
        // Compute: Traverse and print the tree level-by-level 
        static void printTree(Node root)
        {

            // If the root node is null then return nothing
            if (root == null)
            {
                return; // Do Nothing
            }

            int currentLevel = 0;
            Queue<Node> q = new Queue<Node>(); // Error
            q.Enqueue(root);

            // Loop while there is an element in the queue
            while (q.Count > 0)
            {
                Node temp = q.Dequeue();
                // Printing node
                if (temp.Level != currentLevel)
                {
                    System.Console.WriteLine("");
                    System.Console.Write(temp.Value);
                    currentLevel = temp.Level;
                }
                else
                {
                    if (temp == root)
                    { // Special Case: If just the root don't print ", "
                        System.Console.Write(temp.Value);
                    }
                    else
                    {
                        System.Console.Write(", " + temp.Value);
                    }
                }

                if (temp.Left != null)
                {
                    q.Enqueue(temp.Left);
                }

                if (temp.Right != null)
                {
                    q.Enqueue(temp.Right);
                }

            }
        } 
    }
}
