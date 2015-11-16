using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class Recursion
    {
        public class Point
        {
            public int x { get; set; }
            public int y { get; set; }

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        // Q1
        public static long fibonacci(long number)
        {
            if ((number == 0) || (number == 1)) // base cases
                return number;
            else
                // recursion step
                return fibonacci(number - 1) + fibonacci(number - 2);
        }
        
        // Q2
        public static List<Point> current_path = new List<Point>();
        public static bool getPaths(int x, int y) 
        {
             Point p = new Point(x, y);
             current_path.Add(p);
             if (0 == x && 0 == y) return true; // current_path
             bool success = false;
             if (x >= 1 && is_free(x - 1, y)) { // Try right
             success = getPaths(x - 1, y); // Free! Go right
             }
             if (!success && y >= 1 && is_free(x, y - 1)) { // Try down
             success = getPaths(x, y - 1); // Free! Go down
             }
             if (!success) {
             current_path.Remove(p); // Wrong way!
             }
             return success;
         }
        public static bool is_free(int x, int y)
        {
            return true;
        }
    
        // Q3 Subsets
        public static void Helper(string Set)
        {
            AllPerm(Set);
            for (int i = 0; i < AllPerms.Count; i++) //AllSubs
            {
                for (int j = 0; j < AllPerms[i].Count; j++)
                {
                    Console.WriteLine("List " + i + ": " + AllPerms[i][j]);
                }
            }
        }
        public static List<List<string>> AllSubs = new List<List<string>>();
        public static List<string> Sub(string Set)
        {
            List<string> Result;
            if (Set.Length == 0) // Base Case
            {
                Result = new List<string> { "" };
                AllSubs.Add(Result);
                return Result;
            }
            else
            {
                string InputString = Set.Substring(0, Set.Length - 1);
                string LastChar = Set[Set.Length - 1].ToString();
                Result = Sub(InputString);
                List<string> Temp = new List<string>(); 
                Temp.AddRange(Result);
                foreach (string str in Result)
                {
                    Temp.Add(str + LastChar);
                }
                AllSubs.Add(Temp);
                return Temp;
            }
        }
        
        // Q4 Perms
        public static List<List<string>> AllPerms = new List<List<string>>();
        public static List<string> AllPerm(string Str)
        {
            List<string> Result;
            if (Str.Length == 1) // Base Case
            {
                Result = new List<string> { Str };
                AllSubs.Add(Result);
                return Result;
            }
            else
            {
                string InputString = Str.Substring(0, Str.Length - 1);
                char LastChar = Str[Str.Length - 1];
                Result = AllPerm(InputString);
                List<string> Temp = new List<string>();
                foreach (string str in Result)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        char[] TempStr = new char[str.Length + 1];
                        str.CopyTo(0, TempStr, 0, str.Count());
                        TempStr[TempStr.Length-1] = LastChar;
                        char TempChar = TempStr[i];
                        TempStr[i] =  LastChar;
                        TempStr[TempStr.Length - 1] = TempChar;
                        Temp.Add(new string(TempStr));
                    }
                    Temp.Add(str + LastChar);
                }
                AllPerms.Add(Temp);
                return Temp;
            }
        }
    
        public static void printPar(int count) 
        {
            char[] str = new char[count*2];
            printPar(count, count, str, 0);
        }
        public static void printPar(int l, int r, char[] str, int count) 
        {
            if (l < 0 || r < l) return; // invalid state
            if (l == 0 && r == 0) 
            {
                Console.WriteLine(str); // found one, so print it
            } 
            else 
            {
                if (l > 0) 
                { // try a left paren, if there are some available
                    str[count] = '(';
                    printPar(l - 1, r, str, count + 1);
                }
                if (r > l) 
                { // try a right paren, if there’s a matching left
                    str[count] = ')';
                    printPar(l, r - 1, str, count + 1);
                }
            }
        }
    
        //Q 7 MakeChanges
        public static int MakeChange(int n, int denom)
        {
            int next_denom = 0;
            int Remaining = 0;
            switch (denom)
            {
                case 25:
                    next_denom = 10;
                    Remaining = (n % 25);
                    break;
                case 10:
                    next_denom = 5;
                    Remaining = (n % 10);
                    break;
                case 5:
                    next_denom = 1;
                    Remaining = (n % 5);
                    break;
                case 1:
                    return 1;
            }
            int ways = 0;
            for (int i = 0; i * denom <= n; i++)
            {
                ways += MakeChange(n - i * denom, next_denom);
            }
            return ways;
        }

        public static int makeChange(int n, int denom) {
            int next_denom = 0;
            switch (denom) {
                case 25:
                next_denom = 10;
                break;
                case 10:
                next_denom = 5;
                break;
                case 5:
                next_denom = 1;
                break;
                case 1:
                return 1;
            }
            int ways = 0;
            for (int i = 0; i * denom <= n; i++) 
            {
                ways += makeChange(n - i * denom, next_denom);
            }
                return ways;
            }
    
    }
}
