using System;

namespace FumOS.Commands
{
    public class Clear : IExecutable
    {
        public void Execute()
        {
            Console.Clear();
        }
    }
}
