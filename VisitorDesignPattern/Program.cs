using VisitorDesignPattern;

School school = new School();
var visitor1 = new Doctor("James");
school.PerformOperation(visitor1);
Console.WriteLine("************");
var visitor2 = new SalesMan("John");
school.PerformOperation(visitor2);
