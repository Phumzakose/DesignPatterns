namespace PaymentStrategy;

public class CashStrategy : IPayment
{

  public void Pay(double amount)
  {
    Console.WriteLine("The customer pays R " + amount + " with cash");
  }
}