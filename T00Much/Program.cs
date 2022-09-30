using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1 Преобразовать день в дату");
            Console.WriteLine("Введите число от 1 до 365");
            int a = int.Parse(Console.ReadLine());
            DateTime data;
            DateTime dateTime = new DateTime(2022,1,1);
            dateTime.AddYears(2022);
            data =dateTime.AddDays(a-1);
            Console.WriteLine(data.ToString("Дата: d MMMM"));


            Console.WriteLine("Упражнение 4.2 Преобразовать день в дату");
            Console.WriteLine("Введите число от 1 до 365");
            int a2 = int.Parse(Console.ReadLine());
            if (a2 <1 ^ a2 > 365)
            {
                Console.WriteLine("Неправильно попробуй еще раз");
            }
            else
            {
                DateTime data2;
                DateTime dateTime2 = new DateTime(2022, 1, 1);
                dateTime2.AddYears(2022);
                data2 = dateTime.AddDays(a - 1);
                Console.WriteLine(data2.ToString("Дата: d MMMM"));
            }
            

    
            Console.WriteLine("Домашнее Задание 4.1 Преобразовать день в дату");
            Console.WriteLine("Введите число от 1 до 365");
            int a3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год");
            int god = int.Parse(Console.ReadLine());
            if (a3 < 1 ^ a3 > 365)
            {
                Console.WriteLine("Неправильно попробуй еще раз");
            }
            else
            {
                if ((god % 4 == 0 && god % 100 != 0) ^ (god % 400 == 0)) //высокосный
                {
                    if (a3 == 60)
                    {
                        Console.WriteLine($"29 Февраля {god} года");
                    }
                    else
                    {
                        if (a3 < 60)
                        {
                            DateTime data3;
                            DateTime dateTime3 = new DateTime(2022, 1, 1);
                            dateTime3.AddYears(2022);
                            data3 = dateTime3.AddDays(a3 - 1);
                            Console.WriteLine(data3.ToString("Дата: d MMMM"));
                        }
                        else
                        {
                            DateTime data5;
                            DateTime dateTime5 = new DateTime(2022, 1, 1);
                            dateTime5.AddYears(2022);
                            data5 = dateTime5.AddDays(a3 - 2);
                            Console.WriteLine(data5.ToString("Дата: d MMMM"));
                        }
                    }
                }
                else
                {
                    DateTime data4;
                    DateTime dateTime4 = new DateTime(2022, 1, 1);
                    dateTime4.AddYears(2022);
                    data4 = dateTime4.AddDays(a3 - 1);
                    Console.WriteLine(data4.ToString("Дата: d MMMM"));
                }
            }
        }
    }
}
