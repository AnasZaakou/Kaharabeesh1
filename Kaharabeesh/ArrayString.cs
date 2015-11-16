using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class ArrayString // 1.2
    {
        // 1.1
        public static bool IsUnique(string Str)
        {
            bool[] ASCII = new bool[256];
            for (int i = 0; i < Str.Length; i++)
            {
                int Value = Str[i];
                if (ASCII[Value])
                    return false;
                ASCII[Value] = true;
            }
            return true;
        }
        // 1.3
        public static char[] RemoveDups(char[] Input)
        {
            if (Input == null)
                return null;
            else
                if (Input.Length < 2)
                    return Input;
            int i;
            int j;
            int tail = Input.Length - 1;
            for (i = 0; i <= tail; i++)
            {
                for (j = i + 1; j <= tail; j++)
                {
                    if (Input[i] == Input[j])
                    {
                        while (Input[j] == Input[tail])
                            tail--;
                        char temp = Input[j];
                        Input[j] = Input[tail];
                        Input[tail] = temp;
                        tail--;
                    }
                }
            }
            //Array.Copy(Input, Input, tail); Until Tail
            return Input;
        }
        public static bool IsAnagram(string Str1, string Str2)
        {
            int[] Count = new int[256];
            for (int i = 0; i < Str1.Length; i++)
            {
                Count[Str1.ToLower()[i]]++;
            }
            for (int i = 0; i < Str2.Length; i++)
            {
                if (Count[Str2.ToLower()[i]] == 0)
                    return false;
                Count[Str2.ToLower()[i]]--;
            }

            return true;
        }
        public static char[,] Rotate90(char[,] Image)
        {
            int N = Image.GetLength(0);
            for (int rows = 0; rows < N; rows++)
            {
                // Starting from Row 0 Rotate it to Column N-1
                // Row 1 to Column N-1-1
                // Row 2 to Column N-1-2
                // Row N-1 to Column 0
                for (int columns = 0; columns < N; columns++)
                {
                    char Temp = Image[rows, N - 1 - rows];
                    Image[rows, N - 1 - rows] = Image[rows, columns];
                    Image[rows, columns] = Temp;
                }
            }
            return Image;
        }
        public static string ReplaceSpaces(string Str)
        {
            StringBuilder build = new StringBuilder(Str);
            for (int i = 0; i < Str.Length; i++)
            {
                if (build[i] == '\0')
                    build[i] = '%';
            }
            return Str;
        }       
    }
}
