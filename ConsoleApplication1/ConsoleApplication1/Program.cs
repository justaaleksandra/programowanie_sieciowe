using System;
using System.Runtime.Remoting.Lifetime;
using static System.Convert;


namespace ConsoleApplication1
{
    internal class Program
    {
        private static byte[] tab = new byte[5] {1, 2, 5, 7, 9};
        public static void Main(string[] args)
        {
            int k = 1;
            Console.WriteLine(Program.bCRC(tab));
            
        }

        public static int gBite(byte B, int Num)
        {
            return ToInt32((B & (1 << Num - 1)) != 0);
        }

        public static int bCRC(byte[]tab)
        {
            var Ile = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (gBite(tab[i], j) == 1)
                    {
                        Ile++;
                    }
                }
            }
            if ((Ile % 2) == 0)
            {
                return 1;
            }
            return 0;
        }
    }
    
}