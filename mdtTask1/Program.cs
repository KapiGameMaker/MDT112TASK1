using System;

namespace mdtTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Password");
            int password = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Key");
            string key = Console.ReadLine();

            switch (key)
            {
                case "CIA":
                    if (password % 10 == 3 && //1.1
                        password % 100 / 10 != 1 && password % 100 / 10 != 3 && password % 100 / 10 != 5 && //1.2
                        password % 10000 / 1000 >= 6 && password % 10000 / 1000 != 8) //1.3
                        Console.WriteLine("true");
                    else Console.WriteLine("false");
                    break;
                case "FBI":
                    if (password % 1000000 / 100000 >= 4 && password % 1000000 / 100000 <= 7 && //2.1
                        password % 1000 / 100 % 2 == 0 && password % 1000 / 100 != 6 && //2.2
                        password % 100000 / 10000 % 2 == 1) //2.3
                        Console.WriteLine("true");
                    else Console.WriteLine("false");
                    break;
                case "NSA":
                    if ((password % 10 == 1 || password % 10 == 2 || password % 10 == 3 || password % 10 == 5 || password % 10 == 6 ) && //3.1
                        password % 1000 / 100 % 3 == 0 && password % 1000 / 100 % 2 != 0 && //3.2
                        (password % 1000000 / 100000 == 7 || password % 100000 / 10000 == 7 || password % 10000 / 1000 == 7 || //3.3
                        password % 1000 / 100 == 7 || password % 100 / 10 == 7 || password % 10 == 7)
                        )
                        Console.WriteLine("true");
                    else Console.WriteLine("false");
                    break;
                default:
                    Console.WriteLine("Unknown Key Use CIA or FBI or NSA");
                    break;
            }
            Console.Read();
        }
    }
}
