using Cosmos.Core;

namespace FumOS.Commands
{
    public class Exit : IExecutable
    {
        public void Execute()
        {
            ACPI.Shutdown();
        }
    }
}
