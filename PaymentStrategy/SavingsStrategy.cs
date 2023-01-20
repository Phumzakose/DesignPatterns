namespace PaymentStrategy;

public class SavingsStrategy : IPayment
{
  public void Pay(double amount)
  {
    Console.WriteLine("The customer pays R " + amount + " with Savings Account");
  }
}