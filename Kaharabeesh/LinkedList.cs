using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    public class LinkedList
    {
        public class Node
        {
            Node next;
            object value;

            internal Node Next { get; set; }
            internal object Value { get; set; }

            internal Node(object _Value)
            {
                this.Value = _Value;
            }
        }

        Node head;
        internal Node Head { get; set; }

        public LinkedList(object Value)
        {
            Head = new Node(Value);
        }

        public LinkedList()
        {
            // TODO: Complete member initialization
        }
        public Node Add(object Value)
        {
            Node NewNode = new Node(Value);
            if (Head == null)
                Head = NewNode;
            else
            {
                Node Cursor = this.Head;
                while (Cursor.Next != null)
                {
                    Cursor = Cursor.Next;
                }
                Cursor.Next = NewNode;
            }
            return NewNode;
        }
        public bool Delete(object Value)
        {
            if (Head == null)
                return false;
            else if (Head.Value.Equals(Value))
            {
                Head = Head.Next;
                return true;
            }
            else
            {
                Node Cursor = this.Head;
                while (Cursor.Next != null)
                {
                    if (Cursor.Next.Value.Equals(Value))
                    {
                        Cursor.Next = Cursor.Next.Next;
                        return true;
                    }
                    else
                        Cursor = Cursor.Next;
                }
            }
            return false;
        }
        public List<Object> GetElements()
        {
            List<Object> LinkedList = new List<object>();
            if (Head == null)
                return null;
            else
            {
                LinkedList.Add(Head.Value);
                Node Cursor = Head;
                while (Cursor.Next != null)
                {
                    LinkedList.Add(Cursor.Next.Value);
                    Cursor = Cursor.Next;
                }
            }
            return LinkedList;
        }
        
        public LinkedList Reverse(LinkedList List, int K)
        {
            Node Cursor = this.Head;
            for (int i = 1; i < (K-1); i++)
            {
                while (Cursor.Next != null)
                {
                    Cursor.Next = Cursor.Next.Next;
                    Cursor.Next = Cursor;

                    Cursor = Cursor.Next;
                }
            }
            return List;
        }
        // Q1
        public LinkedList RemoveDuplicates(LinkedList List)
        {
            Node TempHead1 = List.Head;
            while (TempHead1 != null)
            {
                Node TempHead2 = TempHead1;
                while (TempHead2.Next != null)
                {
                    if (TempHead1.Value.Equals(TempHead2.Next.Value))
                    {
                        //List.Delete(TempHead2.Value);
                        TempHead2.Next = TempHead2.Next.Next;
                    }
                    else
                        TempHead2 = TempHead2.Next;
                }
                TempHead1 = TempHead1.Next;
            }
            return List;
        }
        // Q3
        public static bool DeleteNode(Node n) // Delete Node Withour Access to Root
        {
            if (n == null || n.Next == null) 
            {
                return false; // Failure
            }
            Node next = n.Next;
            n.Value = next.Value;
            n.Next = next.Next;
            return true;
        }
        // Q4
        public static Node AddLists(Node N1, Node N2, int Carry)
        {
            if (N1 == null && N2 == null)
            {
                if (Carry == 0)
                    return null;
                else
                    return new Node(Carry);
            }
            Node Result = new Node(0);
            int Value = Carry + (int)N1.Value + (int)N2.Value;
            if (Value > 9)
            {
                Carry = 1;
                Result.Value = Value - 10;
            }
            Node Next = AddLists(N1.Next, N2.Next, Carry); // TRICK
            Result.Next = Next;
            return Result;
        }
        // Q5
        public static Node Circular(LinkedList List)
        {
            Node Result = List.Head;
            Hashtable hashtable = new Hashtable();
            while (Result != null)
            {
                if (hashtable.Contains(Result))
                    return Result;
                else
                {
                    hashtable.Add(Result, Result.Value);
                    Result = Result.Next;
                }
            }
            return Result;
        }
    }
}
