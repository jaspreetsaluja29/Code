using System;
using System.Collections.Generic;
using System.Text;

namespace AllPattern
{
    class Pattern3
    {
        public void Patt3()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}