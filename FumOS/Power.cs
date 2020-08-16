using Cosmos.Core;

namespace FumOS
{
    public static class Power
    {
        public static void Shutdown()
        {
            ACPI.Shutdown();
        }

        public static void Reboot()
        {
            ACPI.Reboot();
        }
    }
}
