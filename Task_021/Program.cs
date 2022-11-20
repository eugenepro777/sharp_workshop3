// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними 
// в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите значение x1: ");
var x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение : ");
var y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение: ");
var x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение: ");
var y2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
Console.WriteLine(result);
// dist = Math.Round(dist, 2, MidpointRounding.ToZero); 
