using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {

            string cont;

            do
            {

                double fn;
                double sn;
                string o;
                double answ;
                bool validInput;

                Console.Clear();
                Console.WriteLine("Первое число: ");
                if (double.TryParse(Console.ReadLine(),out fn))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Ошибка.Введите число!");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("Действие %, *, /, +, - , ^ : ");
                o = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Второе число: ");

                if (double.TryParse(Console.ReadLine(), out sn))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Ошибка.Введите число!");
                    Console.ReadKey();
                    break;
                }

                if (o == "^")
                {

                    answ = Math.Pow(fn, sn);
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "+")
                {

                    answ = fn + sn;
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "-")
                {

                    answ = fn - sn;
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "*")
                {

                    answ = fn * sn;
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "/")
                {

                    answ = fn / sn;
                    Console.WriteLine("Результат: " + answ);

                }

                if (o == "%")
                {

                    answ = fn % sn;
                    Console.WriteLine("Результат: " + answ);

                }
                if (sn != 0)
                {
                    answ = fn / sn;

                }
                else
                {
                    Console.WriteLine("Ошибка ");

                }

                Console.WriteLine("Совершить еще одну операцию?");
                cont = Convert.ToString(Console.ReadLine());

            } while (cont == "yes");

        }
    }
}