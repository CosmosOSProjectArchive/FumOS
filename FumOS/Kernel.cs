using Cosmos.System.FileSystem;
using System;
using Sys = Cosmos.System;

namespace FumOS
{
    public class Kernel : Sys.Kernel
    {
        public CosmosVFS VFS { get; private set; }

        protected override void BeforeRun()
        {
            VFS =  new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(VFS);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine($"FumOS {Version.Number} {Version.Codename}");
            Console.WriteLine("Touhou plush and Disk Operating System");
            Console.WriteLine("");
        }

        protected override void Run()
        {
            new Shell(this);
        }
    }
}
