using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            Console.WriteLine("Please, input your numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.ReadLine();

        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            Console.WriteLine("Please, input your numbers!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, input your answer");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b == c)
            {
                Console.WriteLine("Great, this is correct!");
            }
            else Console.WriteLine("Sorry, you are wrong.");
            Console.ReadLine();

        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            Console.WriteLine("Please, input your numbers!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, input your answer");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b == c)
            {
                Console.WriteLine("Great, this is correct!");
            }
            else if (a + b < c) Console.WriteLine("Sorry, you are wrong. Correct answer is less.");
            else Console.WriteLine("Sorry, you are wrong. Correct answer is more.");


            Console.ReadLine();

        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            Console.WriteLine("Please, select operation! (+ or -)");
            char d = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please, input your numbers!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int res;

            if (d == '+') res = a + b;
            else res = a - b;

            Console.WriteLine("Please, input your answer");
            int c = Convert.ToInt32(Console.ReadLine());
            if (res == c)
            {
                Console.WriteLine("Great, this is correct!");
            }
            else if (res < c) Console.WriteLine("Sorry, you are wrong. Correct answer is less.");
            else Console.WriteLine("Sorry, you are wrong. Correct answer is more.");


            Console.ReadLine();

        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            Console.WriteLine("Please, select operation! (+ or -)");
            char d = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please, input your numbers!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int res;

            if (d == '+') res = a + b;
            else res = a - b;


            Console.WriteLine("Please, input your answer:");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 3; i++)
            {
                if (res == c)
                {
                    Console.WriteLine("Great, this is correct!");
                    i = 4;
                }
                else
                {

                    int att = 3 - i;
                    if (res < c) Console.WriteLine($"Sorry, you are wrong. Correct answer is less. You have {att} attemts!");
                    else Console.WriteLine($"Sorry, you are wrong. Correct answer is more. You have {att} attemts!");
                    if (att == 0) Console.WriteLine($"Sorry! No more attempts allowed. Correct answer is {res}.");
                    else
                    {
                        Console.WriteLine("Try again! Please, input your answer:");
                        c = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        
        Console.ReadLine();

        }

    /// <summary>
    /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
    /// Пускай алгоритм складывает пять чисел вместо двух.
    /// </summary>
    public static void B3_P6_9_FiveNumbersAddition()
        {
            Console.WriteLine("Please, select operation! (+ or -)");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please, input your numbers!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());


            int res;

            if (sign == '+') res = a + b + c + d + e;
            else res = a - b - c - d - e;


            Console.WriteLine("Please, input your answer:");
            int answer = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 3; i++)
            {
                if (res == answer)
                {
                    Console.WriteLine("Great, this is correct!");
                    i = 4;
                }
                else
                {

                    int att = 3 - i;
                    if (res < answer) Console.WriteLine($"Sorry, you are wrong. Correct answer is less. You have {att} attemts!");
                    else Console.WriteLine($"Sorry, you are wrong. Correct answer is more. You have {att} attemts!");
                    if (att == 0) Console.WriteLine($"Sorry! No more attempts allowed. Correct answer is {res}.");
                    else
                    {
                        Console.WriteLine("Try again! Please, input your answer:");
                        answer = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        

        Console.ReadLine();

        }

    /// <summary>
    /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
    /// В конце алгоритма выводить информацию была ли задача решена правильно.
    /// </summary>
    public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            // Basically I did it in previous exercises.
        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            const double P = 3.14159;

            Console.WriteLine("Please, input your radius in cm:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Area of your circle is {P * r * r} cm2.");
            Console.ReadLine();

        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            // I really don't know how credits are calculated so it is just my lucky guess :-)

            Console.WriteLine("Please, specify amount of credit you wish to take. Your credit stake will be 18% per year:");
            double sum = Convert.ToDouble(Console.ReadLine());

            double month = sum * 1.18 / 12;

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"Your payment for {i} month will be {month}.");
            }

            Console.ReadLine();

        }
    }
}

