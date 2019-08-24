using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
   public class IfElse
    {
        public void Methodif()
        {
            Console.WriteLine("Enter a string");
            string input;
            input = Console.ReadLine();

            if(input == "")
            {
                Console.WriteLine("your typed string is empty");
            }
            else if(input.Length < 5)
            {
                Console.WriteLine("The string has less than 5 character");
            }
            else if (input.Length < 10)
            {
                Console.WriteLine("the string has atleast 5 but less than 10 character");
 
            }
            else if (input.Length > 10)
            {
                Console.WriteLine("the string has more than 10 character");

            }
            Console.WriteLine("the string was " + input);

        }
    }
}
