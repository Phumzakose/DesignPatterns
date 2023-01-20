using DecoratorPattern;

ICar bmwCar1 = new BMWCar();
bmwCar1.ManufactureCar();
Console.WriteLine(bmwCar1 + "\n");
DieselDecorator carWithDieselEngine = new DieselDecorator(bmwCar1);
carWithDieselEngine.ManufactureCar();
Console.WriteLine();
ICar bmwCar2 = new BMWCar();
PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
carWithPetrolEngine.ManufactureCar();
Console.ReadKey();