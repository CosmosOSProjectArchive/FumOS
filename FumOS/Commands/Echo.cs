using System;

namespace FumOS.Apps
{
    public class Echo : IExecutable
    {
        private readonly string[] _args;
        public Echo(string[] args)
        {
            _args = args;
        }

        public void Execute()
        {
            Console.WriteLine(string.Join(" ", _args));
        }
    }
}
