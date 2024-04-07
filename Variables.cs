using System;

namespace MyApp
{
    class Variables
    {
        static void Main(string[] args)
        {
            int int_val = 12;
            char char_val = 'T';
            bool bool_val = false;
            string string_val = "Hello this are values";
            float float_val = 23.123f;
            double double_val = 12.34d;
            Console.WriteLine("Integer : "+int_val);
            Console.WriteLine("Char : "+char_val);
            Console.WriteLine("boolean : "+bool_val);
            Console.WriteLine("String : "+string_val);
            Console.WriteLine("Float : "+float_val);
            Console.WriteLine("double : "+double_val);
        }
    }
}