using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            var time = DateTime.Today.TimeOfDay;
            TimeSpan span1 = TimeSpan.FromHours(4);
            TimeSpan span2 = TimeSpan.FromHours(12);
            TimeSpan span3 = TimeSpan.FromHours(16);
            TimeSpan span4 = TimeSpan.FromHours(0);

            if (time >= span1 && time < span2) Console.WriteLine("Good Morning, Olga!");
            else if (time >= span2 && time < span3) Console.WriteLine("Good Day, Olga!");
            else if (time >= span3 && time < span4) Console.WriteLine("Good Evening, Olga!");
            else Console.WriteLine("Good Night, Olga!");

            Console.ReadLine();

        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            Console.WriteLine("Please, input your numbers:");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x < y) Console.WriteLine("X is less than Y.");
            else if (x == y) Console.WriteLine("X is equal to Y.");
            else Console.WriteLine("X is more than Y.");

            Console.ReadLine();

        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            Console.WriteLine("Please, input your numbers (More or equal to zero):");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x >= 0 && y >= 0)
            {
                if (x < y) Console.WriteLine("X is less than Y.");
                else if (x == y) Console.WriteLine("X is equal to Y.");
                else Console.WriteLine("X is more than Y.");

            }

            else Console.WriteLine("One or two of your numbers is/are negative!");

            Console.ReadLine();

        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            Console.WriteLine("Please, input your number from 1 to 5:");

            int x = Convert.ToInt32(Console.ReadLine());

            if (x >= 1 && x <= 5)
            {
                Console.WriteLine("3 is your number? (Type Y for 'Yes' and N for 'No'.");
                char a = Convert.ToChar(Console.ReadLine());
                if (a == 'Y' || a == 'y')
                {
                    Console.WriteLine("I won!");
                }
                else
                {
                    Console.WriteLine("Your number is less than 3?");
                    a = Convert.ToChar(Console.ReadLine());
                    if (a == 'Y' || a == 'y')
                    {
                        Console.WriteLine("1 is your number?");
                        a = Convert.ToChar(Console.ReadLine());
                        if (a == 'Y' || a == 'y') Console.WriteLine("I won!");
                        else Console.WriteLine("2 is your number! I won!");
                    }
                    else
                    {
                        Console.WriteLine("5 is your number?");
                        a = Convert.ToChar(Console.ReadLine());
                        if (a == 'Y' || a == 'y') Console.WriteLine("I won!");
                        else Console.WriteLine("4 is your number! I won!");
                    }
                }

            }

            else Console.WriteLine("Your number is less than 1 or more than 5!");

            Console.ReadLine();

        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            var Today = DateTime.Today;
            var DayOfWeek = (int)Today.DayOfWeek;
            //int DayOfWeek = Convert.ToInt32(Console.ReadLine());
            switch (DayOfWeek)
            {
                case 0:
                    Console.WriteLine("Good Sunday, Olga!");
                    break;
                case 1:
                    Console.WriteLine("Good Monday, Olga!");
                    break;
                case 2:
                    Console.WriteLine("Good Tuesday, Olga!");
                    break;
                case 3:
                    Console.WriteLine("Good Wednesday, Olga!");
                    break;
                case 4:
                    Console.WriteLine("Good Thursday, Olga!");
                    break;
                case 5:
                    Console.WriteLine("Good Friday, Olga!");
                    break;
                case 6:
                    Console.WriteLine("Good Saturday, Olga!");
                    break;
                default:
                    Console.WriteLine("Anyway have a good day, Olga!");
                    break;
            }
                    Console.ReadLine();

        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            LabelStart:
char move = Convert.ToChar(Console.ReadLine());
Console.WriteLine();
switch (move)
{
case 'w':
case 'W': Console.WriteLine("Move forward!");
break;
case 's':
case 'S':
Console.WriteLine("Move backward!");
break;
case 'a':
case 'A':
Console.WriteLine("Move left!");
break;
case 'd':
case 'D':
Console.WriteLine("Move right!");
break;
default: Console.WriteLine("Stay put!");
break;
}
goto LabelStart;

        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0) Console.WriteLine($"{i} is even.");
                else Console.WriteLine($"{i} is odd.");
            }
            Console.ReadLine();

        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
            for (int i = 30; i >= 0; i--)
            {
                if (i % 3 == 0) Console.WriteLine(i);
                
            }
            Console.ReadLine();

        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
           Random r = new Random();
            int[,] m = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int k = r.Next(0, 9);
                    m[i, j] = k;
                }

            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{m[i, j]} ");

                }
                Console.WriteLine();
            }
                 

            Console.ReadLine();

        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
            for (int i = 0; i < 6; i++) Console.WriteLine("Hello, World!");
                 

            Console.ReadLine();

        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            for (int i=10; i>0; i--)
            {
                Console.WriteLine($"There were {i} little African American Childrens. And suddenly 1 dead.");
            }
            Console.WriteLine("And then there were none.");
            Console.ReadLine();

        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
            for (int i = 0; i >= -10; i--)
            {
                if (i % 2 == 0) Console.WriteLine($"{i} is even.");
                else Console.WriteLine($"{i} is odd.");
            }
                
            Console.ReadLine();

        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            Console.WriteLine("Please, input your word:");

            string Line = Console.ReadLine();


            char[] Letters = Line.ToCharArray();

            int l = Line.Length;
            int count = 0;

           for (int i=0; i<l; i++)
            {
                if (Letters[i] == 'a' || Letters[i] == 'A') count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            for (int i = 122; i >= 97; i--)
            {
                char letter;
                letter = Convert.ToChar(i);
                Console.Write(letter + " ");
            }
            Console.ReadLine();

        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            Console.WriteLine("Please, input your number:");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i <= x)
            {
                if (i % 2 == 0) Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();

        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
           Console.WriteLine("Please, input your number:");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i <= x)
            {
                if (i % 2 != 0) Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();

        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
            int i = 0;
            while(i < 6)
            {
                Console.WriteLine("Hello, World!");
                i++;
            }
            Console.ReadLine();

        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            Console.WriteLine("Please, input your number:");
            int x = Convert.ToInt32(Console.ReadLine());
            int backup = x;
            Console.WriteLine("Please, input power raise number(exponentiation):");
            int y = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while(i < y)
            {
                x *= backup;
                i++;
            }

            Console.WriteLine(x);
            Console.ReadLine();

        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            int x;
            bool answer = false;
            while (!answer)
            {
                Console.WriteLine("How much will it be: 2+2? Please, input your answer:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 4)
                {
                    Console.WriteLine("This is correct!");
                    break;
                }
                else Console.WriteLine("You are wrong! Please, try again!");
            }
                                   
            Console.ReadLine();

        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            int i = 1;
            int x;
            int sum = 0;
            while (i <= 25)
            {
                Console.WriteLine("Please, input your number (dice result from 1 to 6):");
                x = Convert.ToInt32(Console.ReadLine());
                sum += x;
                i++;
            }

            Console.WriteLine($"Your total sum for 25 turns is: {sum}");
                                   
            Console.ReadLine();

        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
            int i = 1;
            int x;
            int sum = 0; int turn = 1;
            int sum2 = 0; int turn2 = 1;
            while (i <= 50)
            {
                if (i % 2 != 0) {                 
                Console.WriteLine($"Your {turn} turn, Player #1. Please, input your number (dice result from 1 to 6):");
                x = Convert.ToInt32(Console.ReadLine());
                sum += x;
                turn++;
                i++;
                continue;
            }
                else
                {
                    Console.WriteLine($"Your {turn2} turn, Player #2. Please, input your number (dice result from 1 to 6):");
                    x = Convert.ToInt32(Console.ReadLine());
                    sum2 += x;
                    turn2++;
                    i++;
                    continue;
                }
            }

            Console.WriteLine($"Player #1, your total sum for 25 turns is: {sum}");
            Console.WriteLine($"Player #2, your total sum for 25 turns is: {sum2}");

            if (sum > sum2) Console.WriteLine("Congratulations, Player #1, you won!");
            else if(sum2 > sum) Console.WriteLine("Congratulations, Player #2, you won!");
            else Console.WriteLine("This is tie!");

            Console.ReadLine();

        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            Console.WriteLine("Please, input your number (from 1 to 100):");
            int x = Convert.ToInt32(Console.ReadLine());
            char answer;
            
            int i = 0; int j = 0;

           
                while (i < 10)
                {
                    Console.WriteLine($"Your number is between {i * 10} and {i * 10 + 10} ");
                    Console.WriteLine("including borderline values(Y for 'Yes' and N for 'No')?");
                    answer = Convert.ToChar(Console.ReadLine());
                    if (answer == 'Y' || answer == 'y')
                    {
                        while (j <= 10)
                        {
                        Console.WriteLine($"Is your number {i*10+j}?");
                        answer = Convert.ToChar(Console.ReadLine());
                        if (answer == 'Y' || answer == 'y')
                        {
                            Console.WriteLine($"Your number is {i * 10 + j}! I won!");
                            break;
                        }
                            j++;
                        }
                    break;
                    }
                i++;
                }
            

            Console.ReadLine();

        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
        }
    }
}
