namespace MeuProjeto;
using System;
public delegate void CallBackDelegate(int result);

public class Calculator
{
  public void Sum(int a, int b, CallBackDelegate callBack)
  {
    int result = a + b;
    callBack(result);
  }
  public void Multiply(int a, int b, CallBackDelegate callBack)
  {
    int result = a * b;
    callBack(result);
  }

}
