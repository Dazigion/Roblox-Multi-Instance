# Roblox Multi-Instance
Open this program to run multiple Roblox instances (on different accounts) on the same device. Thanks to MainDabRblx.
I do not care how you use this, do what you like, MIT license. If you give aany credit, it should be to MainDabRblx.

Download:
  

Instructions:

  1. Open the program
  2. Make sure to close all instances of Roblox
  3. Press any key
  4. You can now open as many Roblox instances as you want on the same device, granted they are on seperate accounts.

How it works:

  ```c#
  new Mutex(true, "ROBLOX_singletonMutex");
  ```
  Basically, this line of code takes control of the part of Roblox that says "No multi-instance for you!" and disables it.
  You can see the whole thing in #Program.cs
  
More:
  Q. Is this a virus?
  A. It's open source, you can look for yourself.
  Q. Will I get reported in Roblox?
  A. No. It's not against their ToS and is undetectable anyways.
