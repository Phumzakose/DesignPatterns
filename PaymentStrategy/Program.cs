using PaymentStrategy;

Console.WriteLine("Please select payment type : cash, savings or credit");

string paymentType = Console.ReadLine().ToLower();
Console.WriteLine("Payment type is: " + paymentType);

Console.WriteLine("\nPlease enter Amount to Pay : ");

double amount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Thank you for paying " + amount);

PaymentContext pay = new PaymentContext();

if (paymentType == "cash")
{
  pay.SetPayment(new CashStrategy());
}
else if (paymentType == "credit")
{
  pay.SetPayment(new CreditStrategy());
}
else if (paymentType == "savings")
{
  pay.SetPayment(new SavingsStrategy());
}

pay.Pay(amount);