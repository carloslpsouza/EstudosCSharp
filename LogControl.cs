using System;
using System.IO;

public class LogControl
{
  private string path = ".";

  private string prefix = "tst_";
  private string extension = ".log";
  private string completeAddress;
  private DateTime completeDate;
  private string completeDateString;
  public LogControl()
  {
    Console.WriteLine("teste instanciado");
    completeDate = DateTime.Now;
    completeDateString = completeDate.ToString("yyyy-MM-dd");
    completeAddress = path + "/" + prefix + completeDateString + extension;
  }

  public void logCreate()
  {
    if (!File.Exists(completeAddress))
    {
      using (StreamWriter sw = File.CreateText(completeAddress))
      {
        sw.WriteLine(completeDate.ToString("HH:mm:ss.ffff") + " Arquivo de log inciado.");
      }
    }

  }
  public void logRead()
  {
    using (StreamReader sr = File.OpenText(completeAddress))
    {
      string line;
      while ((line = sr.ReadLine()) != null)
      {
        Console.WriteLine(line ?? "");
      }
    }
  }
  public void logWrite(string message)
  {
    string logEntry = completeDate.ToString("HH:mm:ss.ffff") + " " + message;
    File.AppendAllText(completeAddress, logEntry + Environment.NewLine);
  }
  public bool logClean()
  {
    return true;
  }
}
