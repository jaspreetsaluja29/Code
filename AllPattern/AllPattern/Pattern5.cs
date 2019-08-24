using System;
using System.Collections.Generic;
using System.Text;

namespace AllPattern
{
    class Pattern5
    {
        public void Patt5()
        {
            for(char i='A';i<='E';i++)
            {
                for(char j='A';j<='E';j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
