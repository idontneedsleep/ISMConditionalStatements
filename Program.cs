using System;
using System.Windows;


namespace SwitchProjectConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("1.Расшифровка дня недели.");
            Console.WriteLine("2.Расшифровка месяца.");
            Console.WriteLine("3.Выполнение операций над числами.");
            Console.WriteLine("4.Выход");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine("ввести число от 1 до 7");
                            int y = int.Parse(Console.ReadLine());
                            switch (y)
                            {
                                case 1:
                                    Console.WriteLine("понедельник");
                                    break;
                                case 2:
                                    Console.WriteLine("вторник");
                                    break;
                                case 3:
                                    Console.WriteLine("среда");
                                    break;
                                case 4:
                                    Console.WriteLine("четверг");
                                    break;
                                case 5:
                                    Console.WriteLine("пятница");
                                    break;
                                case 6:
                                    Console.WriteLine("суббота");
                                    break;
                                case 7:
                                    Console.WriteLine("воскресенье");
                                    break;
                                default:
                                    Console.WriteLine("ошибка ввода");
                                    break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("ввести число от 1 до 12");
                            int y = int.Parse(Console.ReadLine());
                            switch (y)
                            {
                                case 1:
                                    Console.WriteLine("январь");
                                    break;
                                case 2:
                                    Console.WriteLine("февраль");
                                    break;
                                case 3:
                                    Console.WriteLine("март");
                                    break;
                                case 4:
                                    Console.WriteLine("апрель");
                                    break;
                                case 5:
                                    Console.WriteLine("май");
                                    break;
                                case 6:
                                    Console.WriteLine("июнь");
                                    break;
                                case 7:
                                    Console.WriteLine("июль");
                                    break;
                                case 8:
                                    Console.WriteLine("август");
                                    break;
                                case 9:
                                    Console.WriteLine("сентябрь");
                                    break;
                                case 10:
                                    Console.WriteLine("октябрь");
                                    break;
                                case 11:
                                    Console.WriteLine("ноябрь");
                                    break;
                                case 12:
                                    Console.WriteLine("ноябрь");
                                    break;
                                default:
                                    Console.WriteLine("ошибка ввода");
                                    break;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("ввести числа a и b по очередности");
                            double g;
                            double a = double.Parse(Console.ReadLine());
                            double b = double.Parse(Console.ReadLine());
                            Console.WriteLine("1. Сложение");
                            Console.WriteLine("2. Умножение");
                            Console.WriteLine("3. Вычитание");
                            Console.WriteLine("4. Деление");
                            int z = int.Parse(Console.ReadLine());
                            switch (z)
                            {
                                case 1:
                                    {
                                        g = a + b;
                                        Console.WriteLine(g);
                                        break;
                                    }
                                case 2:
                                    {
                                        g = a * b;
                                        Console.WriteLine(g);
                                        break;
                                    }
                                case 3:
                                    {
                                        g = a - b;
                                        Console.WriteLine(g);
                                        break;
                                    }
                                case 4:
                                    {
                                        g = a / b;
                                        Console.WriteLine(g);
                                        break;
                                    }
                                default:
                                    Console.WriteLine("ошибка ввода");
                                    break;
                            }
                            break;
                        }
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("ошибка ввода");
                        break;
                }
            } while (x != 4);
        }
    }
}
