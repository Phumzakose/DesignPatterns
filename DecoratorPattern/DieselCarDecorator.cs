namespace DecoratorPattern;

public class DieselDecorator : CarDecorator
{
  public DieselDecorator(ICar car) : base(car)
  {

  }
  public void AddEngine(ICar car)
  {
    if (car is BMWCar)
    {
      BMWCar BMWCar = (BMWCar)car;
      BMWCar.Engine = "Diesel Engine";
      Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
    }
  }

  public override ICar ManufactureCar()
  {
    car.ManufactureCar();
    AddEngine(car);
    return car;
  }

}