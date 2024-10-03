using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdditionCalculator
{
    internal class Program
    {
        int calResult; //Fieild (or instance variable) or global variable
        static void Main(string[] args)

        {
            int myR = AddValues(5, 10);
            Console.WriteLine("The sum is: " + myR);

            MyMethod();
            MyMethod2("Successfully");

            //Arrays

            int[] myArray = new int[5];
            myArray[0] = 0;

            int[] myArr = { 1, 2, 3, 4, 5 }; //[1,2,3,4,5]
            string[] mystrarr = { "one", "two", "three", "four", "five" };

            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i]);
            }

            foreach (var item in mystrarr) //we can use string instead of var
            {                 
                Console.WriteLine(item);
            }



            //calculate average
            int currScore;
            int Sum=0;
            int count = 0;
            //do-while loop
            do
            {
                Console.WriteLine("Enter your students score \n Enter -1 to finish! ");
                currScore = int.Parse(Console.ReadLine());
                if(currScore != -1)
                {
                    Sum = Sum + currScore;
                    count++;
                }
               
            } while (currScore != -1);

            int avg = Sum / count;
            Console.WriteLine("The average score is: " + avg.ToString());

            Console.WriteLine("Finally!!!");



            //Prints out whatever is in the quotes
            Console.WriteLine("Hello World!");
            string petsName = "Fluffy";
            Console.WriteLine($"My pets name is: {petsName}");
            
            //takes the user input
           // string userInput = Console.ReadLine();
            //Console.WriteLine( "You entered: " + userInput);

            int myNumber1 = 0;
            int myNumber2 = 0;
            int myNumber = 0;

            int myNum = int.Parse(Console.ReadLine());

            Console.WriteLine("myNumber = " + myNumber);

            Console.WriteLine("Enter the whole number: ");

            string userInput = Console.ReadLine(); // for converting string to int

            bool isNumber = int.TryParse(Console.ReadLine(), out myNumber); // for converting string to int
            Console.WriteLine("You entered: " + userInput);

            //or for better understanding
            Console.WriteLine("Enter the first number1: ");

            string userInput2 = Console.ReadLine();
            myNumber1 = int.Parse(userInput);
            Console.WriteLine( "you entered: " + userInput2);

            Console.WriteLine("Enter the whole number2: ");
            myNumber2 = int.Parse(Console.ReadLine());

            int sum = myNumber1 + myNumber2;
            Console.WriteLine("The sum of " + myNumber1 + " and " + myNumber2 + " is: " + sum);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The value of i is: " + i);
            }

            //explicit conversion
            int myint32 = (int)myNumber;
            //int(myNumber);  

            char myChar = 'A';
            string myString = "Hello";

            //string interpolation
            Console.WriteLine($"my string is {myString} and my char is {myChar}");

            //string formating
            Console.WriteLine("The value of myChar is {0} \n and the number is {1} ", myChar, myint32);

            string myString2 = "this is a string with a slash / and a colon :";
            string s1 = "this is a \"string\" with \n  a blaslash \\ and a colon :";

            Console.WriteLine(s1);
            Console.WriteLine(myString2);

            Console.ReadKey(); //to keep the console open
        }

        static int AddValues(int a, int b)
        {
            int result = a + b;
            return result;
            //Console.WriteLine("The sum of " + a + " and " + b + " is: " + result);
        }

        static void MyMethod()
        {
            Console.WriteLine("My first method was called");
        }

        static void MyMethod2(string myStr)
        {
            Console.WriteLine("My second method was called" + myStr);
        }
    }
}
