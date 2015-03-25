using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
                for (int i = 0; i < item.Length; i++)
                    Console.WriteLine("\t{0}", item[i]);

            }


            while (args.Length > 0)
            {
                Console.WriteLine(args[0]);
                int index = 0;
                do
                {
                    Console.WriteLine("\t{0}", args[0][index++]);
                } while (index < args[0].Length);
                args = args.Skip(1).ToArray();
            }

            string message;

            do
            {

                Console.WriteLine("Write a message");
                message = Console.ReadLine();
                Console.WriteLine("Your message is {0}", message);

            } while (message != "quit");


            Console.ReadLine();
        
        }
    }
}
