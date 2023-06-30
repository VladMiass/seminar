Console.WriteLine("Введи стороны треугольника через пробел");
string[] xyz = Console.ReadLine().Split(" ");
int x = Convert.ToInt32(xyz[0]);
int y = Convert.ToInt32(xyz[1]);
int z = Convert.ToInt32(xyz[2]);
if(x + y > z && y + z > x && z + x > y) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");