using System;
using System.Diagnostics;

namespace KillProcess
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.WriteLine("Enter name process to kill: ");
                string processName = Console.ReadLine();
                if (processName == "")
                    return;
                else if(processName.Contains(".exe"))
                    processName.Replace(".exe", "");
                try
                {
                    foreach(Process p in Process.GetProcessesByName(processName))
                        p.Kill();
                    Console.WriteLine($"{processName} killed!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error, {ex.Message}, {ex.StackTrace}");
                }
                Console.WriteLine("Enter q to quit or enter to continue:");
            } while (Console.ReadLine() != "q");
        }
    }
}
