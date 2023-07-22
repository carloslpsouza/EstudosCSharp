namespace MeuProjeto;
using System;

public class MsgSubscriber : ISubscriber
{
  private string msg;

  public MsgSubscriber(string msg){
    this.msg = msg;
  }
  public void Update(string news){
    Console.WriteLine($"Enviando Mensagem para {msg}: {news}");
  }
}
