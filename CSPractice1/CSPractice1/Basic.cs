using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Basic
    {
        /*        //print statement
                Console.WriteLine("Hello, World!");
                Console.WriteLine("First App");

                //variable inititation
                int i = 10;
                double j = 10.55;
                char initial = 'Y';
                bool mybool = true;
                string str = "Pirunthapan";

                //print values
                Console.WriteLine(i);
                Console.WriteLine(j);
                Console.WriteLine(initial);
                Console.WriteLine(mybool);  
                Console.WriteLine(str);

                //const intitiation
                const int ii = 15;
                Console.WriteLine(ii);

                //string print
                Console.WriteLine("i " + i);
                Console.WriteLine("j " + j);

                //byte of an character
                Console.WriteLine(((byte)initial));

                //Data Types
                int intLengthInBytes = 4;
                long longLengthInBytes = 8;
                float floatLengthInBytes = 4;
                double doubleLengthInBytes = 8;
                //bool length in bytes 1
                //char length in bytes 2
                //string length in bytes 2 bytes per character

                *//*long numbers should be enterred with "L"
                 * Float numbers should be entered with "F"
                 * Double numbers should be entered with "D"
                 * at the end of the numbes
                 */

        /*        long longNumber = 9223372036854775807L;
                Console.WriteLine(longNumber);

                float floatNumber = 3.14515F;
                Console.WriteLine(floatNumber);

                float f1 = 35e3F;
                double d1 = 12e4D;
                Console.WriteLine(f1);
                Console.WriteLine(d1);

                //Type conversion
                Console.WriteLine("Long Number : " + Convert.ToString(longNumber));

                //user Inputs
                Console.WriteLine("Enter UserName : ");

                String userName = Console.ReadLine();

                Console.WriteLine("User Name is : " + userName);


                //Type Casting
                Console.WriteLine("Enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your age is: " + age);

                Console.WriteLine(str.Length);

                int x = 10;

                //Arithmetic Operators
                Console.WriteLine("x / 3 : " + x / 3);
                Console.WriteLine("x % 3 : " + x % 3);
                Console.WriteLine("x & 3 : " + (x & 3));
                Console.WriteLine("x | 3 : " + (x | 3));
                Console.WriteLine("x ^ 3 : " + (x ^ 3));
                Console.WriteLine("x >> 3 : " + (x >> 3));
                Console.WriteLine("x << 3 : " + (x << 3));*/

        /*//Math Operations
        float x = 10.99F;
        Console.WriteLine(Math.Round(x));
        Console.WriteLine(Math.Max(x, 10));
        Console.WriteLine(Math.Sqrt(x));
        Console.WriteLine(Math.Abs(x));

        //String
        string str1 = "CS String 1";
        string str2 = "CS String 2";
        Console.WriteLine(str1 + str1.Length);
        Console.WriteLine(str1.ToArray());
        Console.WriteLine(str1.ToUpper());
        Console.WriteLine(str1.ToLower());

        Console.WriteLine(String.Concat(str1, " Lenght is "));
        String str3 = $"Both Strings are {str1} and {str2}";

        Console.WriteLine(str3[5]);

        Console.WriteLine(str3.IndexOf("S"));
        Console.WriteLine("The character \\ is called backslash.");*/

        /*//If else
        int day = 21;
        if (day < 20)
        {
            Console.WriteLine("Day < 20");
        }
        else
        {
            Console.WriteLine("Day > 20");
        }

        //Short Handed if else
        Console.WriteLine((day < 18) ? "Day < 20" : "Day < 20");*/

        /*        //Switch Statement
                int xx = 100;
                switch( xx )
                {
                    case 100:
                        Console.WriteLine("100");
                        break;
                    case 90:
                        Console.WriteLine("90");
                        break;
                    default:
                        Console.WriteLine("50");
                        break ;
                }*/

        /*        //While Loop with do while
                while (xx > 0)
                {
                    do
                    {
                        Console.Write(xx % 9);
                            xx--;
                    } while (xx % 8 != 0 && xx>0);
                    Console.WriteLine();
                }*/

        /*        //For Loop
                for(int i = 0; i < 100; i++)
                {
                    for(int j = i; j < 99; j++)
                    {
                        Console.Write("x");
                    }

                    Console.Write(" ");

                    for (int k = 100-i; k<100; k++)
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine(); 
                }*/

        /*        //For Each
                string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

                foreach(string i in cars)
                {
                    Console.WriteLine(i);
                }
        */
        /*        //Arrays
                String[] Cars = { "Volvo", "BMW", "Ford", "Mazda" };
                Console.WriteLine(Cars[0]);*/

        /*        //Sorting array
                int[] numbers = { 9, 8, 7, 5, 4, 6, 3, 8, 2, 3 };
                foreach(int i in numbers)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                Array.Sort(numbers);
                foreach(int i in numbers)
                {
                    Console.Write(i);
                }*/

        /* //MultiDimentional Array
         int[,] board = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, };

         foreach(int i in board)
         {
             Console.Write(i);
         }
         Console.WriteLine();

         Console.WriteLine(board[0, 3]);
         board[0, 3] = 5;
         Console.WriteLine(board[0, 3]);*/
    }
}
