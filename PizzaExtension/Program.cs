using Pizza;

PlainPizza pizza = new PlainPizza();

string plainOne = pizza.MakePizza();
Console.WriteLine(plainOne);

PizzaDecorator flavor = new PizzaDecorator(pizza, "cheese");

string test = flavor.MakePizza();

Console.WriteLine(test);
