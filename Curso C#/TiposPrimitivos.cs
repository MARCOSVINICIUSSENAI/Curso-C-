using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class TipoPrimitivo
    {
        public static void ImprimirTipos()
        {

            sbyte SByte = -128;
            Console.WriteLine($"byte:{SByte}");

            byte variavelByte = 255;
            Console.WriteLine($"byte:{variavelByte}");

            short variavelshort = -32768;
            Console.WriteLine($"byte:{variavelshort}");

            ushort variavelUShort = 65535;
            Console.WriteLine($"byte:{variavelUShort}");

            int variavelint = -214758364;
            Console.WriteLine($"int:{variavelint}");

            uint variavelUInt = 4294966111;
            Console.WriteLine($"uint:{variavelUInt}");

            long variavelLong = -9222337026854775808;
            Console.WriteLine($"long:{variavelLong}");

            ulong variavelULong = 18446744073709551615;
            Console.WriteLine($"ulong:{variavelULong}");

            float variavelFloat = 3.14f;
            Console.WriteLine($"float:{variavelFloat}");

            double variavelDouble = 3.141592653589783;
            Console.WriteLine($"double:{variavelDouble}");

            decimal variavelDecimal = 7922816251426543726245M;
            Console.WriteLine($"decimal:{variavelDecimal}");

            char variavelChar = 'A';
            Console.WriteLine($"char:{variavelChar}");

            bool variavelBool = true;
            Console.WriteLine($"bool:{variavelBool}");

            object variavelObject = null;
            Console.WriteLine($"object:{variavelObject}");

            string variavelString = "Olá, Mundo!";
            Console.WriteLine($"string:{variavelString}");
        }

    }
}