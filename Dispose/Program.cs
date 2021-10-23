using System;

namespace Dispose
{
    class Program
    {

        static void Run()
        {
            using PureManagedClass pmc = new PureManagedClass();

            pmc.StartWriting();
        }

        static void Main(string[] args)
        {
            Run();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
