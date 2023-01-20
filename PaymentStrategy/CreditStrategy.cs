namespace PaymentStrategy;

public class CreditStrategy : IPayment
{
  public void Pay(double amount)
  {
    Console.WriteLine("The customer pays R " + amount + " with Credit card");
  }
}