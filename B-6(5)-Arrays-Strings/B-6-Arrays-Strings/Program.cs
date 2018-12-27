using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
            //1DReadConsoleMassive
        {
            var random = new Random();

               int[] array = new int[6];

               for (int i=0; i < 6; i++){
               array[i] = random.Next(0, 10);
               Console.WriteLine(array[i]);
            }
              
            Console.ReadLine();
        }
        
        public static void DMassiveMaxInRow(){
            var random = new Random();

            int[,] array = new int[3,3];

            int max = 0;

            for (int i=0; i < 3; i++){

              for (int j=0; j < 3; j++){

                     array[i,j] = random.Next(0, 10);

                     Console.Write(array[i,j] + " ");

                             if (array[i,j] > max) max = array[i,j];

                  }

                 Console.Write("Maximal number is " + max);

                 Console.WriteLine();

                 max = 0;

           }

            Console.ReadLine();
            
        }

        public static void DMasiveSort(){
            var random = new Random();

            int[] array = new int[5];

            for (int i=0; i < 5; i++){

            array[i] = random.Next(0, 10);

            Console.Write(array[i] + " ");

         }

             for (int j=0; j<4; j++){

                 for (int l=0; l<4-j; l++){

                     int current = 0;

                          if (array[l] > array[l+1]){

                              current = array[l];

                              array[l]=array[l+1];

                              array[l+1]=current;

                           }

                    }

                }

             Console.WriteLine();

                for (int n=0; n < 5; n++){

                Console.Write(array[n] + " ");

            }

            Console.WriteLine();

            Console.ReadLine();
        }
        
        
       
        
        public static void Pyatnashki()
        {
           var random = new Random();

           int[,] array = new int[4,4];

           for (int i=0; i < 4; i++){

              for (int j=0; j < 4; j++){

                 array[i,j] = random.Next(1, 9);

               }

            }

           array[2,2]=0;

           Console.WriteLine();

             for(int l=0; l<4; l++){

                   for(int j=0; j<4; j++){

                       Console.Write(array[l,j] + " ");

             }

              Console.WriteLine();

             }                 

           int l=2; int m= 2; int temp = 0;

           Console.WriteLine();

           Console.WriteLine();

          while(true){

                //W,w - up; S,s - down; A,a - left; D,d - right; F,f - finish

               Console.WriteLine("Choose the direction to move '0', please:");

               char c = Convert.ToChar(Console.ReadLine());

            switch(c){

                  case 'W':

                  case 'w': if (l == 0){Console.WriteLine("Impossible to move! Please, choose another option:"); break;}

                         temp = array [l-1,m];

                         array[l-1,m]=0;

                         array[l,m]=temp;

                         l -= 1;

                         break;

                 case 'S':

                 case 's': if (l == 3){Console.WriteLine("Impossible to move! Please, choose another option:"); break;}

                       temp = array [l+1,m];

                       array[l+1,m]=0;

                       array[l,m]=temp;

                       l += 1;

                       break;

                 case 'A':

                 case 'a': if (m == 0){Console.WriteLine("Impossible to move! Please, choose another option:"); break;}

                       temp = array [l,m-1];

                       array[l,m-1]=0;

                       array[l,m]=temp;

                       m -= 1;

                       break;

                case 'D':

                case 'd': if (m == 3){Console.WriteLine("Impossible to move! Please, choose another option:"); break;}

                       temp = array [l,m+1];

                       array[l,m+1]=0;

                       array[l,m]=temp;

                       m += 1;

                       break;

               case 'F':

               case 'f': goto FinishingMove;

                        default: Console.WriteLine("This is impossible option! Please, choose another one:");

                        break;

               }

                   for(int k=0; k<4; k++){

                      for(int j=0; j<4; j++){

                          Console.Write(array[k,j] + " ");

                               }

                        Console.WriteLine();

                      }

                 Console.WriteLine();

          }

                  FinishingMove:

                     Console.WriteLine("Finishing game!");

                     Console.ReadLine();

           }

        public static void CutString(){
            Console.WriteLine("Please, input your sentence:");

                string s = Console.ReadLine();

                   int l = s.Length;

                    if (l > 13){

                      string res = s.Substring(0,13);

                         Console.WriteLine(res + "...");

                        }

                 else Console.WriteLine(s);

           Console.ReadLine();
            
        }
        
        
        public static void PoemExample()
        {
            Console.WriteLine("Please, input your poem (divide lines by semicolon):");

                 string s = Console.ReadLine();

                 int l = s.Length;

                 string[] split = s.Split(';');

                  foreach(string str in split){

                          string line = str.Replace("o", "a");

                          line = line.Replace("l", "lj");

                          line = line.Replace("t", "tj");

                          line = line.Trim();

                          Console.WriteLine(line);

                  }

                 Console.ReadLine();
            
            
        }
    }
}
