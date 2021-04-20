using System;

namespace consoleapp
{
    class Program
    {
        public static int FindMissNo(int[] a, int n)
        {
            int sum = (n+1) * (n+2) / 2;
            for(int i=0; i< n; i++)
            {
                sum -= a[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5,7,8};
            Console.WriteLine($"Missing no is = {Program.FindMissNo(a, 7)}");
            Console.ReadLine();
        }
    }
}
