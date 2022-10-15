Point GetPoint()
{
    Point point = new Point();
    Console.WriteLine("Введите коорданату X:");
    point.X = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y: ");
    point.Y = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z: ");
    point.Z = int.Parse(Console.ReadLine());

    return point;

}

Point firstPoint = GetPoint();
Point secondPoint = GetPoint();
                //Формула нахождения точек в 3D пространстве..
double result = Math.Sqrt(Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2) + Math.Pow(secondPoint.Z - firstPoint.Z, 2));
Console.WriteLine(result);

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
}