namespace PizzaDecoratorDesign;

public class PlainPizza : IPizza
{
  string? flavor { get; set; }

  public string MakePizza(string flavor)
  {
    string addedFlavour = this.AddFlavour(flavor);
    return "Plain Pizza " + addedFlavour;
  }
}
