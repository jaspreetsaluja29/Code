using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
   public class SwitchCases
    {
        public void switchcasemethod()
        {
            Console.WriteLine("enter the country name and get the language");
            string country;
            country = Console.ReadLine();

            switch (country)
            {
                case "America":
                    Console.WriteLine("english");
                    break;

                case "England":
                    Console.WriteLine("British English");
                    break;

            }


        }
    }
}
