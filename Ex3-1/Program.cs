using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_1
{
    class Complex
    {
        #region Private Fields

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        double im;

        #endregion

        #region Public Properties

        public double Re
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }

        public double Im
        {
            get
            {
                return im;
            }
            set
            {
                if (value == 0)
                {
                    //throw new Exception("Недопустимое значение мнимой части комплексного числа.");
                }

                im = value;
            }
        }

        #endregion


        public Complex()
        {
            re = 5;
            im = 5;
        }

        public Complex(double re, double im)
        {

            if (im == 0)
            {
                //throw new Exception("Недопустимое значение мнимой части комплексного числа.");
            }

            this.re = re;
            this.im = im;
        }


        public Complex Plus(Complex other)
        {
            //Complex res = new Complex(re + other.re, im + other.im);
            //return res;

            return new Complex(re + other.re, im + other.im);
        }

        public Complex Minus(Complex other)
        {
            //Complex res = new Complex(re - other.re, im - other.im);
            //return res;

            return new Complex(re - other.re, im - other.im);
        }

        public Complex Multi(Complex other)
        {
            //Complex res = new Complex(re1re2 - im1im2, re1im2 + re2im1);
            //return res;
            double re1re2, im1im2, re1im2, re2im1;
            re1re2 = re * other.re;
            im1im2 = im * other.im;
            re1im2 = re * other.im;
            re2im1 = other.re * im;

            
            return new Complex(re1re2 - im1im2, re1im2 + re2im1);
        }
        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Введите действительную часть первого числа");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого числа");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите действительную часть второго числа");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго числа");
            d = int.Parse(Console.ReadLine());


            Complex complex01 = new Complex(a, b);
            Complex complex02 = new Complex(c, d);

            Console.WriteLine("1 - сложение, 2 - вычитание, 3 - умножение");
            Console.WriteLine("Выберите нужное действие");
            int number = int.Parse(Console.ReadLine());
            
            switch (number)
            {
                case 1:
                    Task1(complex01, complex02);
                    break;
                case 2:
                    Task2(complex01, complex02);
                    break;
                case 3:
                    Task3(complex01, complex02);
                    break;
                default:
                    Console.WriteLine("Вы ввели некорректный номер задачи");
                    break;
            }
            static void Task1(Complex complex01, Complex complex02)
            {
                Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} равна {complex01.Plus(complex02)}");
            }

            static void Task2(Complex complex01, Complex complex02)
            {
                Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} равна {complex01.Minus(complex02)}");
            }

            static void Task3(Complex complex01, Complex complex02)
            {
                Console.WriteLine($"Произведение комплексных чисел {complex01} и {complex02} равно {complex01.Multi(complex02)}");
            }




        }
        
    }
}
