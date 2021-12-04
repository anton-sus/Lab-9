using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("введите целое число ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите целое число ");
                int b = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("введите код операции: \n 0 - сложение \n 1 - вычитание \n 2 - умножениe \n 3 - деление \n ваш выбор: ");
                int action = Convert.ToInt32(Console.ReadLine());
                int[] array = { 1, 2, 3, 4 };
                int num = array[action];

                if (num == 1)
                {
                    int result = a + b;
                    Console.WriteLine("результат = " + result);
                }
                if (num == 2)
                {
                    int result = a - b;
                    Console.WriteLine("результат = " + result);
                }
                if (num == 3)
                {
                    int result = a * b;
                    Console.WriteLine("результат = " + result);
                }
                if (num == 4)
                {
                    //double a1 = Convert.ToDouble(a);
                    //double b1 = Convert.ToDouble(b);
                    //double result = a1 / b1;
                    int result = a / b;
                    Console.WriteLine("результат = " + result);
                }
            }

            catch (FormatException)
            {
                Console.Write("неправильное число");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("делить на ноль нельзя");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("код за пределами от 0 до 3");
            }

            Console.ReadKey();
        }

    }

}
