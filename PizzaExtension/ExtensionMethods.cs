namespace Pizza;

public static class ExtensionMethod
{
  public static string AddFlavour(this PizzaDecorator plainPizza, string flavour)
  {

    return flavour + " flavour added";

  }
}