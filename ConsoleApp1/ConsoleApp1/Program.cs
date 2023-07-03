using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class ConsoleApp
    {
        private bool osrsRunning = false;
        private string openGame;
        private Process osrs;
        
        private static void Main()
        {
            // Create an instance of the ConsoleApp class
            ConsoleApp consoleApp = new ConsoleApp();

            // Call the CheckProcess method on the instance
            consoleApp.CheckProcess();
        }

        private void CheckProcess()
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                if (process.ProcessName == "RuneLite")
                {
                    osrsRunning = true;
                    osrs = process;
                }
            }

            if (osrsRunning)
            {
                Console.WriteLine("Runescape is Running!");
            }
            else
            {
                Console.WriteLine("Would you like to launch Runescape? Y/N");
                Console.WriteLine(Environment.NewLine);
                openGame = Console.ReadLine().ToUpper();
                Process osrs = new Process();
                OpenRunescape(osrs, openGame);
            }
        }

        private void OpenRunescape(Process osrs, string openGame)
        {
            if (openGame == "Y")
            {
                Console.WriteLine("Opening Runescape...");
                osrs.StartInfo.FileName = "C:\\Users\\Loopypew\\AppData\\Local\\RuneLite\\Runelite.exe";
                osrs.Start();
            }
            else
            {
                Console.WriteLine("Big Mistake Buddy, Opening Runescape");
                osrs.StartInfo.FileName = "C:\\Users\\Loopypew\\AppData\\Local\\RuneLite\\Runelite.exe";
                osrs.Start();
            }
        }
    }
}