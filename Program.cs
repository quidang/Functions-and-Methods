using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace FunctionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Exercise 1
            // Console.WriteLine("Welcome Friends!");
            // Console.WriteLine("Have a nice day!");

            // //Exercise 2
            // Console.WriteLine("Test Data");
            // Console.WriteLine("Please Input a Name");
            // string name = Console.ReadLine();

            // Console.WriteLine("Welcome friend" + name);
            // Console.WriteLine("Have a nice day!");

            // //Exercise 3
            // Console.WriteLine("Test Data");
            // Console.WriteLine("Enter a number!");
            // int number1 = int.Parse(Console.ReadLine());
            // //Enter a second user input
            // Console.WriteLine("Enter a second number!");
            // int number2 = int.Parse(Console.ReadLine());

            // int sum = number1 + number2;
            // Console.WriteLine("The sum of two numbers is:" + sum);

            // Exercise 4
            // string str = "This is a test string";

            // char ch = 's';
            // int freq = 0; 
            // foreach(char c in str) {
            //     if (c == ch) {
            //         freq++;
            //     }
            // }
            // Console.WriteLine(freq);

            // //Exercise 5
            // int[] numbers = new int[5] {5, 7, 3, 2, 9};

            // int sum = 0;

            // Array.ForEach(numbers, i => sum += i);
            // Console.WriteLine(sum);

            // Exercise 6
            // int num1, num2;
            // num1 = 5;
            // num2 = 6;

            // Console.WriteLine("Values before swapping");
            // Console.WriteLine(num1.ToString());
            // Console.WriteLine(num2.ToString());

            // num1 = num1 + num2;
            // num2 = num1 - num2;
            // num1 = num1 - num2;

            // Console.WriteLine("Values after swapping");
            // Console.WriteLine(num1.ToString());
            // Console.WriteLine(num2.ToString());
            
            // Exercise 7
            // {
            // int num1;
            // int exponent1;

            // Console.Write("Function: To calculate the result of raising an integer number to another!");
            // Console.WriteLine("---------------")
            // Console.Write("Input Base number:");
            // num1= Convert.ToInt32(Console.ReadLine());
            // Console.Write("Input the Exponent:");
            // exponent1= Convert.ToInt32(Console.ReadLine());	  
            // Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2} ",num1, exponent1, PowerRaising(num1, exponent1));
            // }

            // static int PowerRaising(int num, int exp)
            // {
            //     int rvalue = 1; 
            //     int i;
            //     for (i=1; i <= exp; i++)
            //     rvalue = rvalue*num;
            //     return rvalue;
            // }

            // Exercise 8
            static int Fibo(int nno)
                {
                int number1 = 0;
                int number2 = 1;

                for (int i = 0; i < nno; i++)
                {
                    int temp = number1;
                    number1 = number2;
                    number2 = temp + number2;
                }
                return number1;
                }
                Console.Write("Function : To display the n number Fibonacci series:");
                Console.Write("------------------------------------------------------------");
                Console.Write("Input number of Fibonacci Series:");
                int n= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The Fibonacci series of "+n+" numbers is :");
                for (int i = 0; i < n; i++)
                {
                Console.Write(Fibo(i)+"  ");
                }
                Console.WriteLine();

            //Exercise 9
                Console.WriteLine("Pick a number: ");
                int n = int.Parse(Console.ReadLine()), a = 0; 

                for (int i = 1; i <= n; i++) {
                    if (n % i == 0) {
                    a++;
                    }
                }
                if (a == 2) {
                    Console.WriteLine("{0} is a Prime Number", n);
                } else {
                    Console.WriteLine("Not a Prime Number");
                }
                Console.ReadLine();

            //Exercise 10
                int SumCal( int n ){

                string n1 = Convert.ToString(n);
                int sum = 0;

                for (int i = 0; i < n1.Length; i++)
                sum += Convert.ToInt32(n1.Substring(i,1));
                return sum;
               }
                int num;
                Console.Write("Enter a number:");
                num = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("The sum of the digits of the number {0} is : {1}",num,SumCal(num));


        }
    }
}
