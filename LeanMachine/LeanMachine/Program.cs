using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var leanController = new LeanController();
            while (true)
            {
                Console.WriteLine("Press 'a' to add a box");
                var result = Console.ReadLine();
                if (result.Trim().Equals("a"))
                {
                    Console.WriteLine("Enter the capacity: ");
                    var capacity = Int16.Parse(Console.ReadLine());
                    leanController.AddBlock(capacity);
                }

                leanController.PrintSystem();
            }


        }


    }
}
