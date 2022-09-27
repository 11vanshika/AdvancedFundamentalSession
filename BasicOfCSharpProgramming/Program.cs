using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOfCSharpProgramming
{
    internal class Program
    {
        //----------User define function call------------//
        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        //---------- Call by  value Function-----------//
        private static void UpdateValue1(int b)
        {
            b = 30;
        }
        //---------------- Call by reference Function---------------------------//
        static void UpdateValue(ref int b)
        {
            b = 30;
        }
        //--------------------- Recursion Function Calling Start -------------------------------//
        static void fun1(int n)
        {
            Console.WriteLine("Fun1 Started");
            fun2(3);
            Console.WriteLine("Fun1 Ended");
        }
        static void fun2(int n)
        {
            Console.WriteLine("Fun2 Started");
            fun3(2);
            Console.WriteLine("Fun2 Ended");
        }
        static void fun3(int n)
        {
            Console.WriteLine("Fun3 Started");
            fun4(1);
            Console.WriteLine("Fun3 Ended");
        }
        static void fun4(int n)
        {
            Console.WriteLine("Fun4 Started");
            Console.WriteLine("Fun4 Ended");
        }
        //----------------------  Recursion Function Calling End -----------------------------//
        static void Main(string[] args)
        {
             // (1)
              // It gets or sets the backgroundground color of the console.
                Console.BackgroundColor = ConsoleColor.Blue;
                //It gets or sets the foreground color of the console.
                Console.ForegroundColor = ConsoleColor.White;
                // It gets or sets the title to display in the console title bar.
                Console.Title = "Understanding console class";
                Console.WriteLine("BackgroundColor: Blue");
                Console.WriteLine("ForegroundColor : White");
                Console.WriteLine("Title : Understanding console class");


                // (2)
                //WriteLine method Print the value and move the cursor to the next line..
                Console.WriteLine("Hello");
                //Wriete method Print the value and stay in the same line..
                Console.Write("hii");
                //ReadLine method reads a string value from the keyboard..
                String letter = Console.ReadLine();
                Console.WriteLine(letter);


                //(3)-------- Data type  ----------// 

                int value = 45;
                Console.WriteLine("Integer Value:" + value);
                double value2 = 3709;
                Console.WriteLine("Double Value: " + value2);
                float value3 = 55.55f;
                Console.WriteLine("Float Value" + value3);
                string value4 = "hello";
                Console.WriteLine(" String Value" + value4);
                char value5 = 'A';
                Console.WriteLine("Character value" + value5);
                bool value6 = true;
                Console.WriteLine("Bool value" + value6);



                // (4) !---------Literals in C#---------- //
                //The fixed values are called Literals in C#..

                //Integer Literals

                // Decimal Literals..
                // Allow Digit: 0-9;
                int letter1 = 110; // No suffix is required;
             // HexaDEcimal Literals ..            
                  int letter2 = 0b1111; //Prefix with 0b..
                                      
             // Decimal Allow Digit and Character : 0-9 and a-f;
                int letter3 = 0X54adf;// Prefix with 0x, and suffix with f..

                Console.WriteLine("Decimal Literals" + letter1);
                Console.WriteLine("Binary literal" + letter2);
                Console.WriteLine("HexaDEcimal Literals" + letter3);


                //(5)----------- Type Conversion -----------//
                //---- Implicit Conversion---//

                Console.WriteLine("Implicit Conversion");
                int letter10 = 546;
                Type letter10Type = letter10.GetType();
                Console.WriteLine($"letter10 Value : {letter10}");
                Console.WriteLine($"letter10 type : {letter10Type}");
                Console.WriteLine($"letter10 size : {sizeof(int)} bytes");

                double letter11 = letter10;
                Type letter11Type = letter11.GetType();
                Console.WriteLine($"letter11 Value : {letter11}");
                Console.WriteLine($"letter11 type : {letter11Type}");
                Console.WriteLine($"letter10 size : {sizeof(double)} bytes");

                // ----Explicit Type Casting----
                double letter15 = 657.89;
                Type letter15Type = letter15.GetType();
                Console.WriteLine($"letter15 Value : {letter15}");
                Console.WriteLine($"letter15 type : {letter15Type}");
                Console.WriteLine($"letter15 size : {sizeof(double)} bytes");
                int letter16 = (int)letter15;
                Type letter16Type = letter16.GetType();
                Console.WriteLine($"letter16 Value : {letter16}");
                Console.WriteLine($"letter16 type : {letter16Type}");
                Console.WriteLine($"letter16 size : {sizeof(int)} bytes");
                //-------- Convert Class Helper Method is c# ----------//

                string str1 = "100";
                Console.WriteLine($"string value:{str1}");
                int letter17 = Convert.ToInt32(str1);
                Console.WriteLine($"String to Int convert: {letter17}");
                string str = "100";
                int i1 = Convert.ToInt32(str);


                //-------- Type Conversion Using Parse() Method -------//
                string str2 = "200";
                Console.WriteLine("String value : " + str2);
                int letter20 = int.Parse(str2);
                Console.WriteLine("String to int conversion with the help of Parse() Method : " + letter20);

                //-----------Variable in c# ---------------------//
                int x = 100; //If we declare a variable explicitly by using the static modifier, we call it a static variable..
                Console.WriteLine("static variable" + x);
                int y = 200; //Non-Static or Instance Variable..
                Console.WriteLine("Non - Static Variable" + y);

                // --------- Operator (Arithmetic operator)--------//
                Console.WriteLine(" Arithmetic Operator");
                int Result;
                int Num1 = 20, Num2 = 10;
                // Addition Operation
                Result = (Num1 + Num2);
                Console.WriteLine($"Addition Operator: {Result}");
                // Subtraction Operation
                Result = (Num1 - Num2);
                Console.WriteLine($"Subtraction Operator: {Result}");
                // Multiplication Operation
                Result = (Num1 * Num2);
                Console.WriteLine($"Multiplication Operator: {Result}");
                // Division Operation
                Result = (Num1 / Num2);
                Console.WriteLine($"Division Operator: {Result}");
                // Modulo Operation
                Result = (Num1 % Num2);
                Console.WriteLine($"Modulo Operator: {Result}");
                //---------------- Assignment operator ----------//
                // Initialize variable number using Simple Assignment Operator "="
                Console.WriteLine("Assignment operator");
                int number = 15;
                number += 10;  //It means number = number + 10 i.e. 15 + 10 = 25
                Console.WriteLine($"Add Assignment Operator: {number}");
                // initialize variable number again
                number = 20;
                number -= 5;  //It means number = number - 5 i.e. 20 - 5 = 15
                Console.WriteLine($"Subtract Assignment Operator: {number}");
                // initialize variable number again
                number = 15;
                number *= 5; //It means number = number * 5  i.e. 15 * 5 = 75
                Console.WriteLine($"Multiply Assignment Operator: {number}");
                // initialize variable number again
                number = 25;
                number /= 5; //It means number = number / 5 i.e. 25 / 5 = 5
                Console.WriteLine($"Division Assignment Operator: {number}");
                // initialize variable number again
                number = 25;
                number %= 5; //It means number = number % 5 i.e. 25 % 5 = 0
                Console.WriteLine($"Modulo Assignment Operator: {number}");

                //---------Relational Operator -----------//
                Console.WriteLine("-----Relational Operator-----");
                bool result1;
                int number1 = 5, number2 = 10;
                result1 = (number1 == number2);
                Console.WriteLine("Equal(=) to Operator: " + result1);
                result1 = (number1 > number2);
                Console.WriteLine("Greater (>) than Operator: " + result1);
                result1 = (number1 < number2);
                Console.WriteLine("Greater (<) than Operator: " + result1);
                result1 = (number1 >= number2);
                Console.WriteLine("Greater (>=) than Operator: " + result1);
                result1 = (number1 <= number2);
                Console.WriteLine("Greater (<=) than Operator: " + result1);
                result1 = (number1 != number2);
                Console.WriteLine("Greater (!=) than Operator: " + result1);


                //-------------- if else statement in c# ----------//
                Console.WriteLine("----if else statement---");

                if (number1 == number2)
                {
                    Console.WriteLine("Both value is same ");
                }
                else
                {
                    Console.WriteLine("Both value is different");
                }

                // --------- Switch Statement -----------//
                Console.WriteLine("-----Switch Statement-----");
                int number8 = 2;
                switch (number8)
                {
                    case 1:
                        {
                            Console.WriteLine("Choice is 1");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Choice is 2");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Choice is 3");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Choice other than 1, 2 and 3");
                            break;
                        }
                }

                //----------For loop --------//
                Console.WriteLine("-----for loop-----");
                for (int i = 0; i < 6; i++)
                {
                    for (int j = i; j < 6; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }
                //--------While loop-----
                Console.WriteLine("--------While loop--------");

                int number11 = 1;
                while (number11 <= 5)
                {
                    Console.WriteLine("Value of number:" + number11);
                    number11++;
                }
                // --------- Do While loop ------//
                Console.WriteLine("--------do while loop---------");
                int number12 = 1;
                do
                {
                    Console.WriteLine($"{number12} ");
                    number12++;
                } while (number12 <= 5);
                //------- Break Statement --------//
                Console.WriteLine("-------break Statement------");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"I : {i}");
                    if (i == 5)
                    {
                        break;
                    }
                }
                Console.WriteLine("Out of for-loop");
                //--------- Continue Statement -------------//
                Console.WriteLine("-------continue Statement------");
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 3)
                    {
                        continue;
                    }
                    Console.WriteLine($"I : {i}");
                }
                //------------- Goto Statement -----------//
                Console.WriteLine("---------- goto Statement-----------");
                Console.WriteLine("1st Statement: ");
                goto label1;   //goto label label1:
                Console.WriteLine("2nd Statement: ");
            label1:    //label:
                Console.WriteLine("3rd Statement: ");
                Console.WriteLine("End of Statement: ");

                //------- Pre Define Function ------//
                Console.WriteLine("---------Pre Define Function-----------");
                int number15 = 25;
                double squareRoot = Math.Sqrt(number15);
                Console.WriteLine($"Square Root of {number15} is {squareRoot}");
            //------------- User Define Function-----------------//
            Console.WriteLine("-----------User Define Function---------");
                int x1, y1;
                x1 = 10;
                y1 = 15;
                int sum = Add(x1, y1);
                Console.WriteLine($"Sum is {sum}");
            //------------------Call by Value ---------------------//
            Console.WriteLine("-----------Call by value---------");
            UpdateValue1(x1);
            Console.WriteLine(x1);

            //-------------- Call by Reference ----------------//
            Console.WriteLine("--------Call By Reference---------");
              int x2 = 20;
            UpdateValue(ref x2);
            Console.WriteLine(x2);
            //-------------------- Recursion ------------------------//
         
            Console.WriteLine("---------Recursion Function Started-----------");
            fun1(4);
            Console.WriteLine("----------Recursion Function End---------------");
            //-------------------- Static and Non Static-----------------------------//
            /*
             * pubilc class Program{
             * int x =10;//Non-static variable
             * static int y = 20; //static variable
             * public static void Main()//Static Block
             * {
             * int a = 10 ; // by default static
             * }
             * void SomeMethod()// Non static Block
             * {
             * int b= 10;// By Default Non-Static
             * }
             * }
             */
            //---------------- Constant Variable --------------//
            Console.WriteLine("constant Variable");
               const float PI = 3.14f; //Constant Variable
            Console.WriteLine(PI);
            //--------------------Override Equals Method -----------------------//
            Console.WriteLine("-------Override Equals Method----------");
            int Number1 = 10;
            int Number2 = 10;
            Console.WriteLine($"Number1 == Number2: {Number1 == Number2}");
            Console.WriteLine($"Number1.Equals(Number2): {Number1.Equals(Number2)}");
            //---------------------Stack and Heap-------------------------//
           /* Class Car {
            * string color = "red";// stack memory
            * static void Main(string[] args){
            * Car myObj = new Car(); // Heap Memory
            * Console.WriteLine(myObj.color)
            * }
            * }
            */
            //-------------------Unchecked ---------------------//
            Console.WriteLine("---------Unchecked---------------");
            int a = 2147483647;
            int b = 2147483647;
            int c = unchecked(a + b);
            Console.WriteLine(c);
            //-----------------------------------------------//
            Console.WriteLine("---------Checked---------------");
            /*int a1 = 2147483647;
            int b1 = 2147483647;
            int c1 = checked(a1+ b1);
            Console.WriteLine(c1);*/
            //-------------------- Boxing-Unboxing --------------------------//
            Console.WriteLine("----------Boxing-UNboxing------------");
            int a2 = 10;
            object b2 = a2; //Boxing
            int z2 = (int)b2; //Unboxing
            Console.WriteLine(z2);
        }
    }
}
