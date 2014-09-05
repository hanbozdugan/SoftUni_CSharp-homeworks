using System;
class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        
       Console.Write("Въведете x координата на точката: ");
       double x = double.Parse(Console.ReadLine());
       Console.Write("Въведете y координата на точката: ");
       double y = double.Parse(Console.ReadLine());
       double r = 1.5;
       int circle = 0;
       int rectangle = 0;
       if ((((x * x) - (2 * x) + 1) + ((y * y) - (2 * y) + 1)) <= (r * r))
       circle = 1;
       if ((x >= -1 && x <= 5) && (y >= -1 && y <= 1))
       rectangle = 1;
       if (circle == 1 && rectangle == 0)
       Console.WriteLine("да");
       else
       Console.WriteLine("не");
    }
}
