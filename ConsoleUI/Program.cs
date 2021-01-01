using ConsoleUI;
using System;

Console.WriteLine("Hello World!");
Console.WriteLine(Add(3, 4));
PersonModel personModel = new PersonModel { Id=1, FirstName="Krishna",LastName="Vijayarajan" };
PersonModel p2 = new(2,"Name2","Name3");
PersonModel p3;
personModel.FirstName = "Krishna Prasad";

if (personModel is not null)
{
    Console.WriteLine($"Hello {personModel.LastName}, {personModel.FirstName} ({personModel.Id})");
}
Console.ReadLine();

//DONT DO THIS
//p3 = new();

static double Add(double x, double y)
{
    return x + y;
}
