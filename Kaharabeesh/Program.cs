using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class Program
    {
        static void Main(string[] args)
        {
            AmazonMe.main();

            //int[] x1 = new int[] { 5, 4, 3, 2, -1, 0 };
            //int[] x2 = new int[] { 5, 4, 3, 2, -1, 0 };
            //Console.WriteLine(x1.SequenceEqual(x2));
            //SortSearch.Selection(new int[] { 5, 4, 3, 2, -1, 0 });
            //SortSearch.Bubble(new int[] { 5,4,3,2,-1,0});
            //int x = 10;
            //Console.WriteLine(x - 1); //9
            //Console.WriteLine(x); //10
            //Console.WriteLine(--x); //9
            //Console.WriteLine(x); //9

            // Ch1 ArrayString
            //char[] Input = new char[] { 'A', 'B', 'A', 'C', 'B', 'D', 'C', 'A' };
            //Console.Write(ArrayString.RemoveDups(Input).Length);

            // Ch8 Recursion
            //Recursion.getPaths(2, 2);
            //Recursion.Helper("abc");
            //Recursion.fibonacci(10);
            //Recursion.printPar(2);
            //Console.Write(Recursion.makeChange(15, 25));

            // Others
            //Other.LongestPalindrome("forgeeksskeegfor");

            //int[] test = { 21, 13, 1, -22, 51, 5, 18 };
            //int[] result = BubbleSort1(test);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i].ToString());
            //}

            //Console.WriteLine("Fibonacci of 4 is " + fibonacci(4));

            //TowersOfHanoi(4, "A", "B", "C");
            //string[] Set = { "a", "b", "c" };
            //Subsets(Set, 0);

            //BST bst = new BST();
            //for (int i = 15; i >= 0; --i)
            //{
            //    bst.insert((2 * i));
            //    bst.insert((2 * i - 5));
            //}
            //bst.printTree();
            //Console.WriteLine("Is 24 in the tree? " + bst.find((24)));
            //Console.WriteLine("Is 27 in the tree? " + bst.find((27)));

            //LinkedList.Node A = new LinkedList.Node('A');
            //LinkedList.Node B = new LinkedList.Node('B');
            //LinkedList.Node C = new LinkedList.Node('C');
            //LinkedList.Node D = new LinkedList.Node('D');
            //LinkedList.Node E = new LinkedList.Node('E');
            //A.Next = B;
            //B.Next = C;
            //C.Next = D;
            //D.Next = E;
            //E.Next = C;
            //LinkedList LL = new LinkedList();
            //LL.Head = A;
            //LinkedList.Node Result = LinkedList.Circular(LL);
            //LinkedList LL = new LinkedList(9);
            //LL.Add(9);
            //LL.Add(9);
            //LL.Add(9);
            //LinkedList LL2 = new LinkedList(9);
            //LL2.Add(9);
            //LL2.Add(9);
            //LL2.Add(9);
            //LinkedList.Node Result = LinkedList.AddLists(LL.Head, LL2.Head, 0);
            //while (Result != null)
            //{
            //    Console.WriteLine((int)Result.Value);
            //    Result = Result.Next;
            //}

            //foreach (var Obj in LL.GetElements())
            //{
            //    Console.WriteLine(Obj.ToString());
            //}
            //Console.WriteLine(Chapter1.IsUnique("anmu"));
            //Console.WriteLine(Chapter1.IsAnagram("Heart", "Earth"));
            //char[,] Image = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
            //Image = Chapter1.Rotate90(Image);
            //for (int rows = 0; rows < 2; rows++)
            //{
            //    for (int columns = 0; columns < 2; columns++)
            //    {
            //        Console.WriteLine(Image[rows, columns]);
            //    }
            //}
            //Stack St = new Stack(4);
            //St.Push(1);
            //St.Push(2);
            //St.Push(3);
            //St.Push(4);
            //St.Pop();
            //St.Display();
            //BinarySearchTree BST = new BinarySearchTree();
            //BST.Insert(5);
            //BST.InOrder(BST.Root);
            //OOP oop = new OOP();
            //Hashtable hash = new Hashtable();
            //HashSet<int> set = new HashSet<int>();
            //List<int> list = new List<int>();
            //Stack<int> st = new Stack<int>();

            //Subs("abc");
            //Other.LongestIncreasingSubsequence(new int[] { 2, 6, 4, 5, 3, 1 });
            //Other.LongestIncreasingSubsequenceRecur(new int[] { 2, 6, 4, 5, 3, 1 }, 0, 0);
            //Other.Print2Files("1.2.3.4: 1,3,4", "1.2.4.4: 1,3,4");
            //BinarySearchTree.Node Root = new BinarySearchTree.Node(10);
            //Root.Left = new BinarySearchTree.Node(5);
            //Root.Right = new BinarySearchTree.Node(11);
            //Root.Left.Left = new BinarySearchTree.Node(4);
            //Root.Right.Right = new BinarySearchTree.Node(12);
            ////List<LinkedList> Result = Graphs.Tree2LinkedList(Root);
            //Graphs.InOrder(Root);


        }

        public static int[] BubbleSort1(int[] array)
        {
            bool swappedOnPrevRun = true;
            while (swappedOnPrevRun)
            {
                swappedOnPrevRun = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        swappedOnPrevRun = true;
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }

        public int[] BubbleSort2(int[] array)
        {
            bool swappedOnPrevRun = true;
            int len = array.Length;
            int j = 1;
            while (swappedOnPrevRun)
            {
                swappedOnPrevRun = false;
                for (int i = 0; i < len - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        swappedOnPrevRun = true;
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                j++;
            }
            return array;
        }

        

        public static void TowersOfHanoi(int n, String start, String auxiliary, String end)
        {
            if (n == 1)
            {
                Console.WriteLine(start + " -> " + end);
            }
            else
            {
                TowersOfHanoi(n - 1, start, end, auxiliary);
                Console.WriteLine(start + " -> " + end);
                TowersOfHanoi(n - 1, auxiliary, start, end);
            }
        }

        public static string Subs(string Set)
        {
            List<string> AllSubsets;
            string result = "";
            if (Set.Length == 0)
            {
                AllSubsets = new List<string>();
                AllSubsets.Add(result);
                //return "";
            }
            AllSubsets = new List<string>();
            while (Set.Length > 0)
            {
                int remaining = 0;
                if (Set.Length > 1)
                    remaining = Set.Length - 1;
                result = Subs(Set.Substring(0, remaining));
                AllSubsets.Add(result);
                List<string> tempList = new List<string>();
                foreach (var str in AllSubsets)
                {
                    tempList.Add(str + Set[Set.Length - 1]);
                }
                AllSubsets.AddRange(tempList);
            }
            return result;
        }

        public static List<List<string>> getSubsets(List<string> set, int index) {
            List<List<string>> allsubsets;
         if (set.Count == index) {
             allsubsets = new List<List<string>>();
             allsubsets.Add(new List<string>()); // Empty set
         } else {
         allsubsets = getSubsets(set, index + 1);
         string item = set[index];
         List<List<string>> moresubsets =
         new List<List<string>>();
         foreach(var subset in allsubsets) {
         List<string> newsubset = new List<string>();
         newsubset.AddRange(subset); //
         newsubset.Add(item);
         moresubsets.Add(newsubset);
         }
         allsubsets.AddRange(moresubsets);
         }
         return allsubsets;
         }
    }
}
