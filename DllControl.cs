using System;
using System.Runtime.InteropServices;

public class DllControl{
  [DllImport("Kernel32.dll")]
  public static extern uint GetTickCount();

  public DllControl(){
    uint tickCount = GetTickCount();
    Console.WriteLine("Sistema ligado à: " + tickCount + " ms");
  }
}