using System;

namespace RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // тестируем исключение при подаче в конструктор 0
            try
            {
                RomanNumber a = new(0);
            }
            catch (RomanNumberException exp)
            {
                Console.WriteLine(exp.Message);
            }

            // тестируем исключение при значении вычитания меньшем/равным 0
            try
            {
                RomanNumber e = new(16);
                RomanNumber f = new(140);
                RomanNumber.Sub(e, f);
            }
            catch (RomanNumberException exp)
            {
                Console.WriteLine(exp.Message);
            }

            // тестируем операции с числами
            try
            {
                RomanNumber a = new(123);
                RomanNumber b = new(520);
                RomanNumber c = new(33);
                RomanNumber d = new(15);
                RomanNumber result;
                RomanNumber[] mas = { a, b, c, d };

                result = RomanNumber.Add(a, b);
                Console.WriteLine($"{a} + {b} = {result}");

                result = RomanNumber.Div(c, d);
                Console.WriteLine($"{c} / {d} = {result}");

                result = RomanNumber.Sub(b, a);
                Console.WriteLine($"{b} - {a} = {result}");

                result = RomanNumber.Mul(c, d);
                Console.WriteLine($"{c} * {d} = {result}");

                // тестируем сортировку
                Console.WriteLine("Неотсортированный массив:");
                foreach (RomanNumber num in mas)
                {
                    Console.WriteLine(num);
                }
                Array.Sort(mas);
                Console.WriteLine("Отсортированный массив:");
                foreach (RomanNumber num in mas)
                {
                    Console.WriteLine(num);
                }
            }
            catch (RomanNumberException exp)
            {
                Console.WriteLine(exp.Message);
            }

        }
    }
}
