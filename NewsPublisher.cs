namespace MeuProjeto;
using System;
using System.Collections.Generic;

public class NewsPublisher
{
  private List<ISubscriber> subscribers = new List<ISubscriber>();
  public void AddSubscriber(ISubscriber subscriber){
    subscribers.Add(subscriber);
    Console.WriteLine($"Subscribe success");
  }
  public void RemoveSubscriber(ISubscriber subscriber){
    subscribers.Remove(subscriber);
    Console.WriteLine($"Unsubscribe success");
  }
  public void PublishNews(string news){
    Console.WriteLine($"Notícia publicada: {news}");
    NotifySubscribers(news);
  }
  private void NotifySubscribers(string news){
    foreach(var subscriber in subscribers){
      subscriber.Update(news);
    }
  }
}
