﻿Console.WriteLine("введите координату х первой точки:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату y первой точки:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату х второй точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату y второй точки:");
int y2 = Convert.ToInt32(Console.ReadLine());
double s = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
Console.WriteLine("S = " + s);