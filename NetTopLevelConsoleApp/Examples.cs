using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTopLevelConsoleApp
{
    static class Examples
    {
        public static void LiteralsExample()
        {
            int countStudents;
            const int maxCount = 20;

            bool flag = false; // true
            int number = 123;
            number = -234;
            number = 0;
            number = 0b00110101;
            number = 0x12AFD56;

            long len = 234L;

            char sym = 'A';

            float x = 123.078F;
            double y = 21432.453;
            y = 234.34e2;

            sym = '\n'; // '\t', '\\'

            string str = "Hello world";

            str = null;
        }

        public static void NativeTypesExample()
        {
            object obj;
            obj = 123;
            obj = "Hello world";
            obj = 23.67;
            obj = true;
            obj = new Random();

            bool flagOne = true;
            Boolean flagTwo = true;


            char symbolOne = '$';
            Char symbolTwo = 'A';


            byte byteOne = 123; // 0..255
            Byte byteTwo = 200;

            sbyte sbyteOne = -25; // -128..127
            SByte sbyteTwo = 25;

            short shortOne = 12345; // -32768..32767
            Int16 shortTwo = 23456;

            ushort ushortOne = 50000; // 0..65535
            UInt16 ushortTwo = 34533;

            int intOne = 2323424; // -2147483648..2147483647
            Int32 intTwo = -324232;

            uint uintOne = 2143234234; // 0..4294967295
            UInt32 uintTwo = 432342;

            long longOne = 132321342423423;
            Int64 longTwo = -34234234234;

            ulong ulongOne = 12313234235434534;
            UInt64 ulongTwo = 3242342342342342;


            float floatOne = 234235354.32445345F;
            Single floatTwo = 234234.324e-2F;

            double doubleOne = 324234.546456;
            Double doubleTwo = 23423.453e23;

            decimal decimalOne = 123123.3242M;
            Decimal decimalTwo = 2342.233e4M;


            string strOne = "Hello";
            String strTwo = "World";


            var n = 123;
        }

        public static void ConsoleWriteExamples()
        {
            string str = "Hello world";
            int number = 123;
            double x = 234.56;
            bool flag = true;
            char sym = '$';

            Console.Write(str);
            Console.WriteLine(str);
            Console.WriteLine(str);
            Console.WriteLine(number);
            Console.WriteLine(x);
            Console.WriteLine(flag);
            Console.WriteLine(sym);

            string name = "Bobby";
            int age = 27;
            double height = 172.5;

            Console.SetCursorPosition(10, 10);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;

            string result = $"Name: {name}, Age: {age + 2}, Height: {height}";
            Console.WriteLine(result);

            Console.WriteLine("Name: {2}, Age: {0}, Height: {1}", age, height, name);
        }

        public static void ConsoleReadExamples()
        {
            string name;

            Console.Write("Input name: ");
            name = Console.ReadLine();

            int age;

            Console.Write("Input age: ");
            age = Int32.Parse(Console.ReadLine());

            double height;
            Console.Write("Input height: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}");
        }

        public static void OperationsExamples()
        {

            int a = 83;
            int b = 22;

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} / {b} = {(double)a + b}");
            Console.WriteLine($"{a} % {b} = {a % b}");

            Console.WriteLine($"++{a} = {++a}");
            Console.WriteLine($"{a}++ = {a++}");
            Console.WriteLine($"{a}");

            int n = 0b01011101; // 93
            int m = 0b00110110; // 54


            Console.WriteLine($"{n} & {m} = {n & m}"); // 0b00010100 // 20
            Console.WriteLine($"{n} | {m} = {n | m}"); // 0b01111111 // 127
            Console.WriteLine($"{n} ^ {m} = {n ^ m}"); // 0b01101011 // 107
            Console.WriteLine($"~{n} = {(byte)~n}"); // 0b10100010 // 162

            Console.WriteLine($"{n} << 1 = {(n << 1)}"); // 0b10111010 // 186
            Console.WriteLine($"{n} << 2 = {(n << 2)}"); // 0b01110100 // 116

            /*
            +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=

            <, >=, >, <=, ==, !=

            &&, ||, ^, !, &, |

            */

            int number = 10;
            if (number < 0 & ++number < 20)
                Console.WriteLine("True");
            Console.WriteLine(number);

            if (true)
            {

            }

            if (number > 0)
            {

            }
            else
            {

            }

            int index = 0;
            while (index < number)
            {

                index++;
            }

            index = 20;
            do
            {
                index++;
            } while (index < number);

            for (int i = 0; i < number; i++)
            {

            }

            for (int i = 0, j = number; i < number; i++, j--)
            {

            }

            int key = 5;
            switch (key)
            {
                case 1:
                    number += 1;
                    break;
                case 3:
                    number -= 3;
                    break;
                case 5:
                    number += 3;
                    break;
                default:
                    number = 100;
                    break;
            }
        }
    }
}
