using System;
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Моля , изберете тип:\n1 --> int\n2 --> double\n3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.Write("Моля въведете число за integer: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
                break;
            case 2: Console.Write("Моля въведете число за double: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b + 1.00);
                break;
            case 3: Console.Write("Моля въведете дума за string: ");
                string c = Console.ReadLine();
                Console.WriteLine(c + "*");
                break;
            default: Console.WriteLine("Не е правилен изборът!"); break;
        }
    }
}
