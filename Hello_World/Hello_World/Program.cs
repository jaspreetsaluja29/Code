using System;

namespace Hello_World
{
   class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i = 10;
            Console.WriteLine(i);

            Type_inference objtype = new Type_inference();
            objtype.Type();

            String_Con objstr = new String_Con();
            objstr.String_Conced();

            IfElse objif = new IfElse();
            objif.Methodif();

            SwitchCases objswitch = new SwitchCases();
            objswitch.switchcasemethod();

            Console.ReadKey();
        }
    }
}
