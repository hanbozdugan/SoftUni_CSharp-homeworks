using System;
class DeclareVariables
{
    static void Main()
    {
        Console.Title = "Five variables";
        ushort unShortNum = 52130;
        sbyte signedByteNum = -115;
        int integerNum = 4825932;
        byte byteNum = 97;
        short signedShortNum = -10000;
        Console.WriteLine("За ushort {0},sbyte {1},int {2},byte {3} и short {4}.", unShortNum, signedByteNum, integerNum, byteNum, signedShortNum);
    }
}
