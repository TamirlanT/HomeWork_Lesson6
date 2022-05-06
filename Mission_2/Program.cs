// See https://aka.ms/new-console-template for more information
Console.Write("Введите k1 = ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2 = ");
var k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b1 = ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2 = ");
var b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1)/(k1-k2);
double y = k1 * x + b1;
Console.WriteLine();
Console.WriteLine($"Точка пересечения: x={x}, y={y}");
