using System;

namespace FumOS.Apps
{
    public class Error : IExecutable
    {
        private readonly string[] _args;
        public Error(string[] args)
        {
            _args = args;
        }

        public void Execute()
        {
            throw new Exception(string.Join(" ", _args));
        }
    }
}
