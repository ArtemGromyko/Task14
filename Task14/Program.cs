using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter email, url or file path:");
            string s = Console.ReadLine();
            bool x = Validating.Validate(s);
            if (!x)
                Console.WriteLine("wrong input!");
            else
                Console.WriteLine("all right");
        }
    }
}
