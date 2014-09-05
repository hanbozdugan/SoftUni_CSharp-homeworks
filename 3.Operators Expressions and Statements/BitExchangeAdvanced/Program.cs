using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        Console.WriteLine(@"'p' не трябва да бъде по-голямо от  'q', и 'k'+'q' не трябва да бъде по-голямо от 32!");
        Console.WriteLine("Въведете число:");
        uint number;
        byte q, k, p;
        bool isNum = uint.TryParse(Console.ReadLine(), out number);
        Console.WriteLine("Въведете номер на малката позиция на първият bit,откъдето ще почва смяната: ");
        bool isP = byte.TryParse(Console.ReadLine(), out p);
        Console.WriteLine("Въведете номер на голямата позиция на първият bit,откъдето ще почва смяната:");
        bool isQ = byte.TryParse(Console.ReadLine(), out q);
        Console.WriteLine("Въведете брой bit,които ще се сменят местата:");
        bool isK = byte.TryParse(Console.ReadLine(), out k);
        string str = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine("Преди : {0}", str);
        p = (byte)(p - 1);
        q = (byte)(q - 1);
        if ((isNum && isP && isQ && isK) && (p < q && (k + q) <= 32))
        {
            while (k != 0)
            {
                int mask = 1 << p, maskSecond = 1 << q;
                uint maskBit = (uint)(number & mask);
                uint maskBitS = (uint)(number & maskSecond);
                if ((maskBit >> p) == (maskBitS >> q)) { goto here; }
                if ((maskBit >> p) != (maskBitS >> q) && (maskBit >> p != 0))
                {
                    int reverseMask = ~(1 << p);
                    number = (uint)(number | maskSecond);
                    number = (uint)(number & reverseMask);

                }
                else if ((maskBit >> p) != (maskBitS >> q) && (maskBitS >> q != 0))
                {
                    int reverseMask = ~(1 << q);
                    number = (uint)(number | mask);
                    number = (uint)(number & reverseMask);

                }
            here: ;
                p++;
                q++;
                k--;
            }
            Console.Write("След това:  ");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        }
        else Console.WriteLine("Грешен обхват");
   
    }
}
