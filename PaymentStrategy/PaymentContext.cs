namespace PaymentStrategy;

public class PaymentContext
{
  private IPayment payment;

  public void SetPayment(IPayment payment)
  {
    this.payment = payment;
  }

  public void Pay(double amount)
  {
    payment.Pay(amount);
  }
}