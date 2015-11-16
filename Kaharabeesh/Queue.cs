using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class Queue
    {
        int Size;
        object[] Q;
        int Rear;
        int Head;

        public Queue(int Capcaity)
        {
            Size = Capcaity;
            Q = new object[Size];
            Rear = -1;
        }
        public void EnQ(object Item)
        {
            while (Rear < Size - 1)
            {
                ++Rear;
                Q[Rear] = Item;
            }
        }
        public object DeQ()
        {
            Head++;
            return Q[0];
        }
    }
}
