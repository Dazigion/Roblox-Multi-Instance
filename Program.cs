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
            		Console.WriteLine(" Welcome to Roblox Multi-Instance!\n");
			Thread.Sleep(300); //Mainly because of the astetic of "loading"
			bool IsActive;
			Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex",out IsActive);
			try
			{
				if (!IsActive) {
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("Either its already running or you need to rejoin!");
				}
				mutex.WaitOne();
			}
			catch
			{
				mutex = new Mutex(true, "ROBLOX_singletonMutex");
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Roblox Multi-Instance is now activated!\n");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Originally made by MiningTcup, some credit to MainDabRblx, Modified by Dazigion");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("> You CANNOT use the same account\n> Closing this window causes to deactivate!\n");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("https://github.com/Dazigion/Roblox-Multi-Instance/");
			Thread.Sleep(-1);
		
        }
    }
}
