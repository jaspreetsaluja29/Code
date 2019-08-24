using System;

namespace AllPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattren1 objpattren1 = new Pattren1();
            objpattren1.Patt1();
            Console.WriteLine();

            Pattern2 objpatter2 = new Pattern2();
            objpatter2.Patt2();
            Console.WriteLine();

            Pattern3 objpatter3 = new Pattern3();
            objpatter3.Patt3();
            Console.WriteLine();

            Pattern4 objpatter4 = new Pattern4();
            objpatter4.Patt4();
            Console.WriteLine();

            Pattern5 objpatter5 = new Pattern5();
            objpatter5.Patt5();
            Console.WriteLine();

            Console.ReadKey(true);
        }
        
    }
}
