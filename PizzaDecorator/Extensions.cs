namespace PizzaDecoratorDesign;

public static class Extensions
{
  public static string AddFlavour(this PlainPizza flavour, string flavor)
  {
    string message = "";
    if (flavor == "bacon")
    {

      message = "cheese and bacon flavour added";

    }
    else if (flavor == "chicken")
    {
      message = "chicken and mashroom flavour added";
    }

    return message;
  }

}