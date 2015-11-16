using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kaharabeesh
{
    class Other
    {
        public static void LongestIncreasingSubsequence(int[] Elements)
        {
            if (Elements.Length == 0)
                Console.WriteLine("Empty Array");
            else
            {
                List<List<int>> Sequences = new List<List<int>>();
                List<int> Sequence0 = new List<int>();
                Sequence0.Add(Elements[0]);
                Sequences.Add(Sequence0);
                int CurrentSequence = 0;
                for (int i = 0; i < Elements.Length; i++)
                {
                    if ((i + 1) < Elements.Length)
                    {
                        if (Elements[i + 1] > Elements[i])
                            Sequences[CurrentSequence].Add(Elements[i + 1]);
                        else
                        {
                            /* compare a[i+1] with all elements in current sequence 
                               until finding element x  < a[i+1] then copy elements of current sequence from begining until x to new sequence 
                               and add a[i+1] to and make currentsequence = new sequence if x not found
                               continue on loop
                             */
                            for (int j = Sequences[CurrentSequence].Count - 2; j >= 0; j--)
                            {
                                if (Elements[i + 1] > Sequences[CurrentSequence][j])
                                {
                                    //copy elements of current sequence from begining until x to new sequence 
                                    //and add a[i+1] to and make currentsequence = new sequence if x not found
                                    List<int> NewSequence = new List<int>();
                                    NewSequence.AddRange(Sequences[CurrentSequence].GetRange(0, j+1));
                                    NewSequence.Add(Elements[i + 1]);
                                    Sequences.Add(NewSequence);
                                    CurrentSequence++;
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < Sequences.Count; i++)
                {
                    //if (i + 1 < Sequences.Count)
                         Console.WriteLine(Sequences[i].Count + "---" + Sequences[i].Sum().ToString());
                }
            }
        }
        public static List<int> LongestIncreasingSubsequenceRecur(int[] Elements, int Index, int CurrentSequence)
        {
            List<List<int>> Sequences = new List<List<int>>();
            List<int> Sequence;
            if (Elements == null)
                return null;
            else
            {
                List<int> Sequence0 = new List<int>();
                Sequence0.Add(Elements[0]);
                Sequences.Add(Sequence0);
                Sequence = LongestIncreasingSubsequenceRecur(Elements, Index + 1, CurrentSequence);
                while (Index + 1 < Elements.Length)
                {

                }
            }
            return Sequence;
        }
        public static void Print2Files(string Line1, string Line2)
        {
            // First Compare Each Number in IP1 wih it's equivalent in IP2
            string[] IP1 = Line1.Substring(0, Line1.IndexOf(':')).Split('.');
            int[] Numbers1 = Array.ConvertAll(Line1.Substring(Line1.IndexOf(':')+1).Split(','), int.Parse);
            string[] IP2 = Line2.Substring(0, Line2.IndexOf(':')).Split('.');
            int[] Numbers2 = Array.ConvertAll(Line2.Substring(Line2.IndexOf(':')+1).Split(','), int.Parse);
            string Result = "";
            bool IPsREqual = false;
            int i;
            for (i= 0; i < IP1.Length; i++)
            {
                if (IP1[i] != IP2[i])
                {
                    IPsREqual = false;
                    Result += IP1[i];
                    return;
                }
                else
                {
                    Result += IP1[i];
                    IPsREqual = true;
                }
            }
            if (IPsREqual)
            {
                // sort & print numbers
               
            }
            else
            {
                for (int j = i+1; j < IP1.Length; j++)
                {
                    Result += IP1[j];
                }
            }
        }
        static void TestMethod2(ref int[] Numbers1, ref int[] Numbers2)
        {
            Array.Sort(Numbers1);
            Array.Sort(Numbers2);
        }
        public static void LongestPalindrome(string Input)
        {
            int LongestLength = 0;
            StringBuilder Temp = new StringBuilder("");
            char[] Reverse;
            for (int i = 0; i < Input.Length; i++)
            {
                Temp.Append(Input[i]);
                Reverse = Temp.ToString().Reverse().ToArray();
                if (Temp.ToString().ToArray().SequenceEqual(Reverse))
                    LongestLength = Temp.Length > LongestLength ? Temp.Length : LongestLength;
            }
            Console.WriteLine(LongestLength);
        }
    }
}
