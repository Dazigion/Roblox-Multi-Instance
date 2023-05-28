using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;

namespace MultipleRoblox
{
    internal class Program
    {
		
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Roblox Multi-Instance!\n");
			Thread.Sleep(300); //Mainly because of the astetic of "loading"
			bool IsActive;
			Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex",out IsActive);
			try
			{
				if (!IsActive) {
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Please close all Launched Roblox Instances for this to work, thanks! \n\n");
				}
				mutex.WaitOne();
			}
			catch
			{
				mutex = new Mutex(true, "ROBLOX_singletonMutex");
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Roblox Multi-Instance is now activated!\n");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Please do not close this window\n\n");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("Originally made by MiningTcup, some credit to MainDabRblx \n \n Modified by Dazigion\n\n--- NOTES ---\nYou may now open as many Roblox instances as you like, ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("using seperate accounts");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(". If you close this window, all Roblox instances except for one will close. Make sure that you closed all Roblox instances before activating this.\n");
			Console.ForegroundColor = ConsoleColor.White;
			Thread.Sleep(-1);
		
        }
    }
}
