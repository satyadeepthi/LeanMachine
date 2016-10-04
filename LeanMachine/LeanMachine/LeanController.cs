using System;
using System.Collections.Generic;
using System.Linq;

namespace LeanMachine
{
    public class LeanController
    {
        private readonly List<Block> blocks;

        public LeanController()
        {
            blocks = new List<Block>();
        }

        public void AddBlock(int capacity)
        {

            Queue queue = blocks.Any() ? new Queue((CalculateThroughput() - capacity) < 0 ? 0 : (CalculateThroughput() - capacity)) : new Queue(0);

            blocks.Add(new Block(capacity, queue));
        }

        
        public void Reset()
        {
            blocks.Clear();
        }

        public int CalculateThroughput()
        {
            if (HopNumber <= blocks.Count)
            {
                return 0;
            }

            return blocks.Select(x => x.Capacity).Min();
        }

        public int HopNumber { get; set; }

        public void PrintSystem()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Print System:");
            for (int i = 0; i < blocks.Count; i++)
            {
                Console.WriteLine("Block Index: " + (i+1) + "\nBlock Capacity :" + blocks[i].Capacity);
                Console.WriteLine("Queue size: " + blocks[i].Queue.Value);
            }
            Console.WriteLine("Throughput: " + CalculateThroughput());
            Console.WriteLine();
        }
    }
}