using System;

public class Program{
  static void Main(){
    LogControl Log = new LogControl();
    Log.logCreate();
    Log.logWrite("teste");

    DllControl onTime = new DllControl();  
  }
}
