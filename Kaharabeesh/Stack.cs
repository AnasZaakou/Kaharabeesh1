using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class Stack
    {
        int Size;
        object[] Items;
        int Top;
        public Stack(int Capcaity)
        {
            Size = Capcaity;
            Items = new object[Size];
            Top = -1;
        }
        public void Push(object Obj)
        {
            if (Top == Size)
                Console.WriteLine("Stack Is Full");
            else
            {
                Top++;
                Items[Top] = Obj;
            }
        }
        public object Pop()
        {
            if (Top == -1)
                return null;
            else
            {
                return Items[Top--];
            }
        }
        public void Display()
        {
            for (int i = Top; i > -1; i--)
            {

                Console.WriteLine("Item {0}: {1}", (i + 1), Items[i]);
            }
        }
    }
}
