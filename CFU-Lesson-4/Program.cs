using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFU_Lesson_4
{
    internal class Program
    {
        enum card
        {
            шестерк, семерка, восьмерка, девятка, десятка, валет, дама, король, туз
        }
        public enum dninedel
        {
            Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1. Вася и окно");
            Console.WriteLine("Введите длину форточки");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину форточки");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы Васи");
            double d1 = double.Parse(Console.ReadLine());
            if (a1 - d1 >= 1 && b1 - d1 >= 1)
            {
                Console.WriteLine("Голова пролезет");
            }
            else
            {
                Console.WriteLine("Упс голова не пролезет");



            Console.WriteLine("Задание 2. Таблица умножения на число n");
            Console.WriteLine("Введите число n");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"n*{i} = {n2 * i}");
            }

            /*
            Console.WriteLine("Задание 3. Принимает на вход число и возвращает слово");
            Console.WriteLine("Введите число");
            int a3 = int.Parse(Console.ReadLine());
            if (a3 % 15 == 0)
            {
                Console.WriteLine("БэнгБум");
            }
            else if (a3 % 5 == 0)
            {
                Console.WriteLine("Бум");
            } 
            else if (a3 % 3 == 0)
            {
                Console.WriteLine("Бэнг");
            }
            else
            {
                Console.WriteLine("Мимо");
            }
            */


            Console.WriteLine("Задание 3. Принимает на вход число и возвращает слово");
            Console.WriteLine("Введите число");
            int a3 = int.Parse(Console.ReadLine());
            string Answer;
            Answer = a3 % 15 == 0 ? "BengBoom" : a3 % 5 == 0 ? "Boom" : a3 % 3 == 0 ? "Beng" : "None";
            Console.WriteLine(Answer);



            Console.WriteLine("Задание 4. Строка с заглавными буквами");
            Console.WriteLine("Введите строку");
            string lena = Console.ReadLine();
            string a = " "; // Чар пустой
            int dlena = lena.Length;
            while (dlena > 0)
            {
                char c4 = lena[dlena - 1];
                if (char.IsUpper(c4) ^ c4 == a[0])
                {
                    dlena--;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(dlena == 0 ? true : false);


            Console.WriteLine("Задание 5.Вывести овец");
            Console.WriteLine("Введите сколько овец в стаде");
            int n5 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n5; i++)
            {
                Console.Write($"{i + 1} овца...");
            }
            Console.WriteLine();

            Console.WriteLine("Задание 6.Не понял как делать");
            Console.WriteLine("Задание 7.Не понял как делать");
          


            Console.WriteLine("Задание 8. Проход по массиву ");
            int c8 = 0;
            string[] stroki = { "Hello Kitty", "Mama", "JOpa", "Barbie doll" };
            foreach (string i in stroki)
            {
                if (i == "Hello Kitty" ^ i == "Barbie doll")
                {
                    c8++;
                }
            }
            Console.WriteLine($"В сумке было {c8} Кукол(ы)");



            Console.WriteLine("Задание 9. Дни недели");
                Console.WriteLine("Введите цифру дня недели");
            int n9 = int.Parse(Console.ReadLine());
            if (n9 > 0 && n9 < 7)
            {
                Console.WriteLine($"Ваш день недели -{(dninedel)n9}");
            }
            else
            {
                Console.WriteLine("Под таким номером нет дня недели");
            }


            
            Console.WriteLine("Задание 10. Массив по возрастанию");
            int c;
            int[] arr1 = { 32, 13123, 222, -9, 0 };
            int[] arr2 = { 32, 13123, 222, -9, 0 };
            int[] arr3 = { 32, 13123, 222, -9, 0 };
            int lena1 = arr2.Length;
            Array.Sort(arr1);
            for (int ik = 0; ik < lena1; ++ik)
            {
                Console.Write(arr1[ik] + " ");
            }
            Console.WriteLine();


            for (int b = 0; b < lena1; b++)
            {
                for (int i = 0; i < arr2.Length - 1; i++)
                {
                    if (arr2[i] > arr2[i + 1])
                    {
                        c = arr2[i];
                        arr2[i] = arr2[i + 1];
                        arr2[i + 1] = c;
                    }
                }
            }
            for (int i = 0; i < lena1; ++i)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();


            for (int i = 0; i < arr3.Length - 1; i++)
            {
                for (int j = i + 1; j < arr3.Length; j++)
                {
                    if (arr3[i] > arr3[j])
                        (arr3[i], arr3[j]) = (arr3[j], arr3[i]);
                }
            }



                Console.WriteLine("Задание 11. По возрастанию");
            int[] arr = { 1, 23, 421, 124 };
            int call = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Console.WriteLine($"Строка сломалась на {i} элементе массива");
                    break;
                    call++;
                }
            }
            Console.WriteLine(call == arr.Length ? "Массив упорядочен по возрастанию" : "");








            }
        }

    }
}
