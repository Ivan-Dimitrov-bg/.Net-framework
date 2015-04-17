//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class Program
{
    // GetChar(15) -> 'F'
    static char GetChar(int i)
    {
        if (i >= 10) return (char)('A' + i - 10);
        else return (char)('0' + i);
    }

    // GetNumber("587", 2) -> 7
    static int GetNumber(string s, int i)
    {
        return s[i] - '0';
    }

    static string Base2ToBase16(string b)
    {
        if (b.Length % 4 != 0) return Base2ToBase16(new String('0', 4 - b.Length % 4) + b); // Padleft

        string h = String.Empty;

        // Read 4 by 4 and convert to hex
        for (int i = b.Length - 1; i >= 0; i -= 4)
        {
            int nibble = 0;

            for (int j = 0, power = 1; j < 4; j++, power *= 2)
                nibble += GetNumber(b, i - j) * power;

            h = GetChar(nibble) + h;
        }

        return h;
    }

    static void Main()
    {
        Console.WriteLine(Base2ToBase16("11111101"));
    }
}
//using System;

//class HexToBinary
//{
//    static void Main()
//    {
//        string hexadec = Console.ReadLine();
//        ConvertHexToBinary(hexadec);
//    }
//    static void ConvertHexToBinary(string input)
//    {
//        int len = input.Length;
//        int binary = 0;
//        int count = 0;
//        for (int i = len - 1; i >= 0; i--, count++)
//        {
//            switch (input[i])
//            {
//                case 'A': binary = binary | (10 << 4 * count); break;
//                case 'B': binary = binary | (11 << 4 * count); break;
//                case 'C': binary = binary | (12 << 4 * count); break;
//                case 'D': binary = binary | (13 << 4 * count); break;
//                case 'E': binary = binary | (14 << 4 * count); break;
//                case 'F': binary = binary | (15 << 4 * count); break;
//                default: binary = binary | ((input[i] - 48) << 4 * count); break;
//            }
//        }
//        Console.WriteLine(Convert.ToString(binary, 2).PadLeft(32, '0'));
//    }
//}