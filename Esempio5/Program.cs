using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*sbyte b1 = -100;
            char b2 = 'B';
            Console.WriteLine($"Value is:{ b2}");
            Console.WriteLine($"Equals to ASCII:{(char)b2}");
            Console.WriteLine($"Minimum value of signed byte: {(int)char.MinValue} and maximum {(int)char.MaxValue}");
            Console.WriteLine($"Size of signed byte: {sizeof(char)} byte(s)");
            */

            short x = 123;
            int y = 456;
            long z =789;
            z = 111;
            Console.WriteLine($"Minimum if Int16: {short.MinValue}\nMaximum of Int16: {short.MaxValue}\nThe memory size: {sizeof(short)}");
            Console.WriteLine($"Minimum if Int32: {int.MinValue}\nMaximum of Int32: {int.MaxValue}\nThe memory size: {sizeof(int)}");
            Console.WriteLine($"Minimum if Int64: {long.MinValue}\nMaximum of Int64: {long.MaxValue}\nThe memory size: {sizeof(long)}");
            
            
            ushort x1 = 123;
            uint y1 = 456;
            ulong z1 = 789;
            z = 111;
            Console.WriteLine($"\n\n\nMinimum if ushort: {ushort.MinValue}\nMaximum of ushort: {ushort.MaxValue}\nThe memory size: {sizeof(ushort)}");
            Console.WriteLine($"Minimum if uint: {uint.MinValue}\nMaximum of uint: {uint.MaxValue}\nThe memory size: {sizeof(uint)}");
            Console.WriteLine($"Minimum if ulong: {ulong.MinValue}\nMaximum of ulong: {ulong.MaxValue}\nThe memory size: {sizeof(ulong)}");

            Single s = 1.123f; //4 bytes
            Double d = 1.321; //8 bytes
            Decimal de = 1.332M; //16 bytes

            Console.WriteLine($"\n\n\nMinimum if Single: {Single.MinValue}\nMaximum of Single: {Single.MaxValue}\nThe memory size: {sizeof(Single)}");
            Console.WriteLine($"Minimum if Double: {Double.MinValue}\nMaximum of uint: {Double.MaxValue}\nThe memory size: {sizeof(Double)}");
            Console.WriteLine($"Minimum if Decimal: {Decimal.MinValue}\nMaximum of ulong: {Decimal.MaxValue}\nThe memory size: {sizeof(Decimal)}");

            float f = 1.123f; //4 bytes
            double dou = 1.321; //8 bytes
            decimal dec = 1.332M; //16 bytes

            Console.WriteLine($"\n\n\nMinimum if float: {float.MinValue}\nMaximum of float: {float.MaxValue}\nThe memory size: {sizeof(float)}");
            Console.WriteLine($"Minimum if double: {double.MinValue}\nMaximum of uint: {double.MaxValue}\nThe memory size: {sizeof(double)}");
            Console.WriteLine($"Minimum if decimal: {decimal.MinValue}\nMaximum of ulong: {decimal.MaxValue}\nThe memory size: {sizeof(decimal)}");

            Console.Read();
        }
    }
}
