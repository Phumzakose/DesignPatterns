namespace Pizza;

public class PizzaDecorator : IPizza
{

  string AddedFlavour { get; set; }

  private IPizza pizza;

  public PizzaDecorator(IPizza pizza, string addedFlavour)
  {
    this.pizza = pizza;
    this.AddedFlavour = addedFlavour;
  }

  public string MakePizza()
  {
    return pizza.MakePizza() + this.AddFlavour(AddedFlavour);
  }
}