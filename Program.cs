namespace MeuProjeto;
using System;
using System.Collections.Generic;

public class Program{
  static void Main(){
    //Teste callback
    /* Calculator calculadora = new Calculator();

    CallBackDelegate callBack = DisplayResult;

    calculadora.Sum(2, 2, callBack);
    calculadora.Multiply(3, 5, callBack);

    static void DisplayResult(int result){
      Console.WriteLine($"O resultado é: {result}");
    } */
    
    //Teste Design Subscriber
    var publisher   = new NewsPublisher();
    var subscriber1 = new MsgSubscriber("Subscriber 01");
    var subscriber2 = new MsgSubscriber("Subscriber 02");

    publisher.AddSubscriber(subscriber1);
    publisher.AddSubscriber(subscriber2);

    Console.WriteLine("Digite mensagem 1 de 2: ");
    var InputTest1 = Console.ReadLine();
    Console.WriteLine("Digite mensagem 2 de 2: ");
    var InputTest2 = Console.ReadLine();

    publisher.PublishNews(InputTest1 ?? "Nulo");
    publisher.PublishNews(InputTest2 ?? "Nulo");

    publisher.RemoveSubscriber(subscriber2);

    publisher.PublishNews("Mensagem 3");
    
    //Teste DLLs
    //DllControl onTime = new DllControl();

    //Teste de classes
    //LogControl Log = new LogControl();
    //Log.logCreate();
    //Log.logWrite("teste");

  }
}
