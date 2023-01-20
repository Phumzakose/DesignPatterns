namespace ObserverPattern;

public class Observer : IObserver
{
  public string UserName { get; set; }

  public Observer(string username, ISubject subject)  //the observer need to know about the subject that is why we pass it as an argument
  {
    UserName = username;
    subject.RegisterObserver(this);
  }

  public void Update(string availabiliy)
  {
    Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
  }
}