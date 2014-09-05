using System;
class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Напишете колко килограма тежите:");
        double mass = double.Parse(Console.ReadLine());
        double Moon = mass*0.17;
        Console.WriteLine("Твоите килограми на луната ще бъдат: {0}кг",Moon);
    }
}
