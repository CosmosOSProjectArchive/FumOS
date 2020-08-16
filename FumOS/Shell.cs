using Cosmos.Core;
using FumOS.Apps;
using System;
using System.Linq;

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
                    case "clear":
                        Console.Clear();
                        break;

                    case "piano":
                        new Piano().Start();
                        break;

                    case "echo": 
                        Console.WriteLine(string.Join(" ", args));
                        break;

                    case "shutdown":
                        ACPI.Shutdown();
                        break;

                    default:
                        Console.WriteLine("unknown command");
                        break;
                }
            }
        }
    }
}
