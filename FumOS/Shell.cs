using Cosmos.Core;
using FumOS.Apps;
using FumOS.Commands;
using System;

namespace FumOS
{
    public class Shell
    {
        private readonly Kernel _kernel;

        public Shell(Kernel kernel)
        {
            _kernel = kernel;
            Start();
        }

        private void Start()
        {
            while (true)
            {
                Console.Write("fumos> ");

                var input = Console.ReadLine().Split(" ");

                var command = input[0];
                string[] args = new string[input.Length - 1];
                Array.Copy(input, 1, args, 0, args.Length);

                switch (command)
                {
                    // Commands

                    case "clear":
                        _kernel.Execute(new Clear());
                        break;

                    case "exit":
                        _kernel.Execute(new Exit());
                        break;

                    case "echo":
                        _kernel.Execute(new Echo(args));
                        break;

                    case "error":
                        _kernel.Execute(new Error(args));
                        break;

                    // Apps

                    case "piano":
                        _kernel.Execute(new Piano());
                        break;                 

                    // Default action

                    default:
                        Console.WriteLine("unknown command");
                        break;
                }
            }
        }
    }
}
