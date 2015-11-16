using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class Bit
    {
        public static uint swapOddEvenBits(uint x) 
        {
            return ( ((x & 0xaaaaaaaa) >> 1) | ((x & 0x55555555) << 1) );
        }
         uint swapBits(uint x)
        {
            // Get all even bits of x
            uint even_bits = x & 0xAAAAAAAA; 
 
            // Get all odd bits of x
            uint odd_bits  = x & 0x55555555; 
 
            even_bits >>= 1;  // Right shift even bits
            odd_bits <<= 1;   // Left shift odd bits
 
            return (even_bits | odd_bits); // Combine even and odd bits
        }
    }
}
