using System;

namespace Ex3_2
{
    class Program
    {
        //С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
        //Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму
        //вывести на экран, используя tryParse.
        static void Main(string[] args)
        {
            int i, sum;
            string s;
            bool flag;
            sum = 0;
            Console.WriteLine("Вводите числа по одному. Для завершения работы программы введите 0");
            do
            {
                s = Console.ReadLine();
                flag = int.TryParse(s, out i);
                if (flag != true)
                {
                    Console.WriteLine("Ввод некорректен, работа программы будет завершена");
                    return;
                }
                
                if (i % 2 !=0 && i >0)
                {
                    sum = sum + i;
                } 

            } while (i != 0);
            Console.WriteLine($"сумма нечетных положительных чисел равна {sum}");

        }
    }
}
