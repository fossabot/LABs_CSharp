using System;
using System.Threading;

namespace LABs
{
    internal static class Labs
    {
        public static void Main()
        {
            const string variants = "Введите номер варианта лабораторной работы:\n " +
                                    "1 - Найти гипотенузу и площадь прямоугольного треугольника\n " +
                                    "2 - Вычисление a и b по заданной формуле\n " +
                                    "3 - Найти длины биссектрис треугольника\n " +
                                    "4 - Среди двух действительных чисел выести первое, если оно больше второго, иначе оба числа\n " +
                                    "5 - Вычисление f(a) по заданной формуле\n " +
                                    "6 - Определить, принадлежит ли точка заштрихованной части плоскости\n " +
                                    "8 - Выяснить, угрожает ли ферзь на одном поле другому полю\n " +
                                    "9 - Вывести последнюю цифру натурального числа меньше или равного 100\n " +
                                    "10 - Выяснить, все ли 4 цифры числа различны\n " +
                                    "11 - Вычислить по заданной формуле\n " +
                                    "14 - Вычислить по формуле последовательно слева направо\n " +
                                    "0 - Выход из программы\n";
            Console.Write(variants);
            var variant = Convert.ToDouble(Console.ReadLine());
            while (variant != 0)
            {
                Console.Clear();
                switch (variant)
                {
                    case 1:
                        var lab1 = new Lab1();
                        lab1.lab1();
                        break;
                    case 2:
                        var lab2 = new Lab2();
                        lab2.lab2();
                        break;
                    case 3:
                        var lab3 = new Lab3();
                        lab3.lab3();
                        break;
                    case 4:
                        var lab4 = new Lab4();
                        lab4.lab4();
                        break;
                    case 5:
                        var lab5 = new Lab5();
                        lab5.lab5();
                        break;
                    case 6:
                        var lab6 = new Lab6();
                        lab6.lab6();
                        break;
                    case 8:
                        var lab8 = new Lab8();
                        lab8.lab8();
                        break;
                    case 9:
                        var lab9 = new Lab9();
                        lab9.lab9();
                        break;
                    case 10:
                        var lab10 = new Lab10();
                        lab10.lab10();
                        break;
                    case 11:
                        var lab11 = new Lab11();
                        lab11.lab11();
                        break;
                    case 14:
                        var lab14 = new Lab14();
                        lab14.lab14();
                        break;
                    default:
                        Console.WriteLine("Введен неверный номер варианта");
                        break;
                }
                Thread.Sleep(5000);
                Console.Clear();
                Console.Write(variants);
                variant = Convert.ToDouble(Console.ReadLine());
            }
        }
    }

    internal class Lab1
    {
        public void lab1 ()
        {
            Console.Write("Введите значение a: ");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Math.Sqrt(Math.Sqrt(a) + Math.Sqrt(b));
            var s = 0.5 * a * b;
            Console.WriteLine("Гипотенуза равна - " + c + "\nПлощадь равна - " + s);
        }
    }

    internal class Lab2
    {
        public void lab2()
        {
            Console.Write("Введите значение x: ");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y: ");
            var y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение z: ");
            var z = Convert.ToDouble(Console.ReadLine());
            var a = ((1 + Math.Pow(Math.Sin(x + y), 2)) /
                     (2 + Math.Abs(x - (2 * x) / (1 + (Math.Pow(x, 2) * Math.Pow(y, 2)))))) + x;
            var b = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);
            Console.WriteLine("Переменная a = " + a + "\nПеременная b = " + b);
        }
    }

    internal class Lab3
    {
        public void lab3()
        {
            Console.Write("Введите значение a: ");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            var b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение c: ");
            var c = Convert.ToDouble(Console.ReadLine());
            var la = Math.Sqrt((a * b * (a + b + c) * (a + b + c)) / (a + b));
            var lb = Math.Sqrt((a * c * (a + b + c) * (a + b + c)) / (a + c));
            var lc = Math.Sqrt((c * b * (a + b + c) * (a + b + c)) / (c + b));
            Console.WriteLine("Длинна биссектрисы a = " + la + "\nДлинна биссектрисы b = " + lb +
                              "\nДлинна биссектрисы c = " + lc);
        }
    }

    internal class Lab4
    {
        public void lab4()
        {
            Console.Write("Введите первое число: ");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else {
                Console.WriteLine(a + "" + b);
            }
        }
    }

    internal class Lab5
    {
        public void lab5()
        {
            Console.Write("Введите значение x: ");
            var x = Convert.ToDouble(Console.ReadLine());
            var a = Math.Pow(x, 2) + 4 * x + 5;
            if (x <= 2)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(1 / a);
            }
        }
    }

    internal class Lab6
    {
        public void lab6()
        {
            Console.Write("Введите значение x: ");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y: ");
            var y = Convert.ToDouble(Console.ReadLine());
            var r = Math.Sqrt(x * x + y * y);
            if (r <= 1 && r >= 0.5)
            {
                Console.WriteLine("Точка принадлежит заштрихованной областе");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит заштрихованной областе");
            }
        }
    }

    internal class Lab8
    {
        public void lab8()
        {
            Console.Write("Введите значение k: ");
            var k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение l: ");
            var l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение m: ");
            var m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение n: ");
            var n = Convert.ToDouble(Console.ReadLine());
            if (((k == m) && (l == n)) && ((k == m) || (l == n) || (Math.Abs(k - m) == Math.Abs(l - n))))
            {
                Console.WriteLine("Ферзь угрожает");
            }
            else
            {
                Console.WriteLine("Ферзь не угрожает");
            }
        }
    }

    internal class Lab9
    {
        public void lab9()
        {
            Console.Write("Введите натуральное число <= 100: ");
            var n = Convert.ToDouble(Console.ReadLine());
            if (n < 100 && n >= 10)
            {
                Console.WriteLine("Последняя цифра числа " + n + " -> " + (n % 10));
            }
            else if (n < 9 && n >= 1)
            {
                Console.WriteLine("Последняя цифра числа " + n + " -> " + n);
            }
            else if (n == 100)
            {
                Console.WriteLine("Последняя цифра числа " + n + " -> " + 0);
            }
            else
            {
                Console.WriteLine("Число не соответствует условию");
            }
        }
    }

    internal class Lab10
    {
        public void lab10()
        {
            Console.Write("Введите натуральное число <= 9999: ");
            var n = Convert.ToDouble(Console.ReadLine());
            var nl = Convert.ToString(n).Length;
            var n1 = Math.Floor(n / 1000);
            var n2 = Math.Floor((n % 1000) / 100);
            var n3 = Math.Floor((n % 100) / 10);
            var n4 = Math.Floor(n % 10);
            var res = false;
            switch (nl)
            {
                case 4:
                    if (n1 == n2 && n1 == n3 && n1 == n4)
                    {
                        res = true;
                    }
                    break;
                case 3:
                    if (n2 == n3 && n2 == n4)
                    {
                        res = true;
                    }
                    break;
                case 2:
                    res = n3 == n4;
                    break;
                case 1:
                    Console.WriteLine("Вы ввели одно число! Оно одинаково.");
                    break;
                default:
                    Console.WriteLine("Число не соответствует условию");
                    break;
            }

            if (nl > 1 && nl <= 4)
            {
                if (res)
                {
                    Console.WriteLine("Все " + nl + " цифры числа одинаковы");
                }
                else
                {
                    Console.WriteLine("Все " + nl + " цифры числа различны");
                }
            }
        }
    }

    internal class Lab11
    {
        public void lab11()
        {
            Console.Write("Введите натуральное число: ");
            var n = Convert.ToDouble(Console.ReadLine());
            var x = (Math.Cos(1) / Math.Sin(1));
            for (var i = 2; i < n; i++)
            {
                var y = ((Math.Cos(1) + Math.Cos(n)) / (Math.Sin(1) + Math.Sin(n)));
                x *= y;
            }
            Console.WriteLine("Результат: " + x);
        }
    }

    internal class Lab14
    {
        public void lab14()
        {
            double y = 1 - 1 / 2;
            for (double i = 3; i < 9999; i++)
            {
                var x = 1 / i;
                y += x;
            }
            
            y -= 1 / 10000;
            Console.WriteLine("Результат: " + y);
        }
    }
}
