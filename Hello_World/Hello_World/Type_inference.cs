using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    public class Type_inference
    {
        public void Type()
        {

            var name = "bunny";
            var age = 25;
            var israbbit = true;
            Type typename = name.GetType();
            Type typeage = age.GetType();
            Type typeisrabbit = israbbit.GetType();

            Console.WriteLine($"name of the type {typename}");
            Console.WriteLine($"age of the type {typeage}");
            Console.WriteLine(typeisrabbit);
            Console.ReadKey();
        }
    }
}
