using PizzaDecoratorDesign;

PlainPizza plainPizzaObj = new PlainPizza();

string? message = Console.ReadLine();
string plainPizza = plainPizzaObj.MakePizza(message!);
Console.WriteLine(plainPizza);


// PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizzaObj);
// string chickenPizza = chickenPizzaDecorator.MakePizza();
// Console.WriteLine(chickenPizza);

// Console.WriteLine("\n'" + chickenPizza + "' using ChickenPizzaDecorator");
// VegPizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(plainPizzaObj);
// string vegPizza = vegPizzaDecorator.MakePizza();
// Console.WriteLine("\n'" + vegPizza + "' using VegPizzaDecorator");
