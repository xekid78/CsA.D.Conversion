using System;

namespace Ccalconv
{
    class Ccalconv
    {
        static void Main(string[] args)
        {
            for (int seireki = 1926; seireki <= 1935; seireki++)
            {
                Console.Write("西暦" + seireki + "年は");
                int syowa = seireki - 1925;
                Console.WriteLine("昭和" + syowa + "年です");
            }
        }
    }
}
