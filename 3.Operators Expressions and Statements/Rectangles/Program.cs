using System;
class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Въведете първата страна на правоъгълника в см:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Въведете втората страна на правоъгълника в см:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Лицето на правоъгълника е: {0} кв.см", a*b);
        Console.WriteLine("Обиколката на правоъгълника е: {0} см", a*2+b*2);
    }
}
