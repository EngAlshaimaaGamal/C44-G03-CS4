using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1.Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Enter the number ");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine($"The Number : {number}");
            //Console.ReadKey();


            #endregion

            #region Q2
            //2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            //string number = "route";
            ////int x = (int)number; // explicit casting  invalid

            //int.TryParse(number, out int num);
            //Console.WriteLine(num);  


            #endregion

            #region Q3

            //3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float number1 = 15.555f, number2 = 20.222f, result;
            //result = number1 + number2;
            //Console.WriteLine(result);
            //result = number1 - number2;
            //Console.WriteLine(result);

            //result = number1 * number2;
            //Console.WriteLine(result);

            //result = number1 / number2;
            //Console.WriteLine(result);

            //result = number1 % number2;
            //Console.WriteLine(result);








            #endregion


            #region Q4
            //4.Write C# program that Extract a substring from a given string.
            //string name = "Alshaimaa Gamal Dahy";
            //string result = name.Substring(0, 15);
            //Console.WriteLine(result);



            #endregion
            #region Q5

            //int number1 = 10;
            //int number2 = 20;


            //Console.WriteLine(number1);
            //Console.WriteLine(number2);

            //number2 = number1;
            //Console.WriteLine($" After Assign number2 = number1  {number2}");

            //number1 = 120;

            //Console.WriteLine($"Number1 after modify {number1}");
            //Console.WriteLine(number2);





            #endregion

            #region Q6
            //6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Point p1 = new Point();
            //p1.x = 5;
            //p1.y = 15;

            //Point p2 = new Point();
            //p2.x = 88;
            //p2.y = 30;

            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);

            //p2 = p1;
            //Console.WriteLine("After P2 = P1");
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);

            //p1.x = 200;
            //p1.y = 90;
            //Console.WriteLine("After change p1");
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine(p2.x);
            //Console.WriteLine(p2.y);








            #endregion

            #region Q7

            // 7.Write C# program that take two string variables and print them as one variable 

            //string name1 = "Alshaimaa";
            //string name2 = "Gamal Dahy ";
            //Console.WriteLine($"name is : {name1} {name2}"); // string interpolation
            // string result =string.Format("Name {0} {1}", name1, name2); // string formate
            // Console.WriteLine(result);
            //Console.WriteLine(string.Format("Name {0} {1}", name1, name2)); // Composite formating
            //Console.WriteLine(name1 + name2); // concatenation




            #endregion
            #region Q8

            //8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 

            //float interest;
            //int BalanceAmount = 5000;
            //float rate = 0.12f;
            //int year = 5;
            //interest = BalanceAmount * rate * year; 
            //Console.WriteLine(interest);


            #endregion

            #region Q9
            //9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 

            // Console.WriteLine("Enter the weight ");
            //int.TryParse(Console.ReadLine() ,out int Weight);
            // Console.WriteLine("Enter the Height ");
            // int.TryParse(Console.ReadLine(), out int Height);

            // int BMI = Weight/(Height*Height) ;
            // Console.WriteLine($" BMI = {BMI} K/m");



            //Console.WriteLine("Enter the weight ");
            // double Weight=Convert.ToInt32(Console.ReadLine() );
            //Console.WriteLine("Enter the Height ");
            //  double Height=Convert.ToInt32(Console.ReadLine());

            //double BMI = Weight / (Height * Height);
            //Console.WriteLine($" BMI = {BMI} K/m");












            #endregion

            #region Q10

            //10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 

            //Console.WriteLine("Enter the ternary ");
            // int tempary  = Convert.ToInt32(Console.ReadLine());
            //string result = tempary < 10 ? "cold" : tempary > 30 ? "Hot" : "Just Good";
            //Console.WriteLine(result);  


            #endregion

            #region Q11


            // 11.Write a program that takes the date from the user and displays it in various formats using string interpolation.

            //Console.WriteLine("Enter the Date ");
            //int day = Convert.ToInt32(Console.ReadLine());
            //int month = Convert.ToInt32(Console.ReadLine());
            //int year = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($" Today's  Date is {day} ,{month} ,{year}");
            //Console.WriteLine($" Today's  Date is {day} /{month} /{year}");
            //Console.WriteLine($"  Today's Date is {day} .{month} .{year}");





            #endregion

            #region Q12
            //12- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("Enter the number : ");
            // int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 3==0 && number % 4 == 0    )
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No"); 






            #endregion

            #region Q13
            //13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("Enter the number : ");
            // int number = Convert.ToInt32(Console.ReadLine());
            //if (number < 0)
            //    Console.WriteLine($"Negative number {number}");

            //else
            //    Console.WriteLine($"Positive number {number}");


            #endregion

            #region Q14

            // 14 - Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.WriteLine("Enter the number1 : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the number2 : ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the number3 : ");
            //int number3 = Convert.ToInt32(Console.ReadLine());

            //int max = number1;
            /// use ternary operator 
            //int resultMax = max > number2 ? max : number2 > number3 ? number2 : number3;
            //Console.WriteLine($"Max element {resultMax}");
            //int Min = number1;
            //int resultMin = Min< number2 ? Min : number2 < number3 ? number2 : number3;
            //Console.WriteLine($"Min Element {resultMin}");



            ///use if statment 
            ///

            //int max = number1;
            //int min = number1;

            //    if (max > number2)
            //    {
            //        if (max > number3)

            //            Console.WriteLine(max);
            //        else
            //        {
            //            max = number3;
            //            Console.WriteLine(max);
            //        }
            //    }
            //   else
            //    {
            //        max = number2;
            //        if (max > number3)
            //            Console.WriteLine(max);
            //        else
            //        {
            //            max = number3;
            //            Console.WriteLine(max);

            //        }


            //    }

            //if (min < number2)
            //{
            //    if (min< number3)

            //        Console.WriteLine(min);
            //    else
            //    {
            //        min = number3;
            //        Console.WriteLine(min);
            //    }
            //}
            //else
            //{
            //    min = number2;
            //    if (min < number3)
            //        Console.WriteLine(min);
            //    else
            //    {
            //        min = number3;
            //        Console.WriteLine(min);

            //    }


            //}

















            #endregion



            #region Q15
            //15- Write a program that allows the user to insert an integer number then check If a number is even or odd

            //Console.WriteLine("Enter the number1 : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //if (number1 % 2 == 0)
            //    Console.WriteLine("Even number ");
            //else
            //    Console.WriteLine("odd number");



            #endregion


            #region Q16

            //16- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)

            //Console.WriteLine("Enter the char ");
            //char character = Convert.ToChar(Console.ReadLine() ?? "No Char");
            //if ((character == 'a' || character == 'i' || character == 'o' || character == 'e' || character == 'u') || (character == 'A' || character == 'I' || character == 'O' || character == 'E' || character == 'U')) 
            //    Console.WriteLine("vowel character");
            //else
            //    Console.WriteLine("Consonant character");  


            #endregion


            #region Q17
            //17- Write a program to input the month number and print the number of days in that month.


            //Console.WriteLine("Enter the Month Number ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //switch (number)
            //  {
            //        case 1:
            //        Console.WriteLine("31");
            //        break;
            //        case 2:
            //        Console.WriteLine("28");
            //         break;
            //        case 3:
            //        Console.WriteLine("31");
            //        break;
            //        case 4:
            //        Console.WriteLine("30");
            //        break;
            //        case 5:
            //        Console.WriteLine("31");
            //        break;
            //        case 6:
            //        Console.WriteLine("30");
            //        break;
            //        case 7:
            //        Console.WriteLine("31");
            //        break;  
            //        case 8:
            //        Console.WriteLine("31");
            //        break;
            //        case 9:
            //        Console.WriteLine("30");
            //        break;
            //        case 10:
            //        Console.WriteLine("31");
            //        break;
            //        case 11:
            //        Console.WriteLine("30");
            //        break;
            //        case 12:
            //        Console.WriteLine("31");
            //        break;
            //    default:
            //        Console.WriteLine("no month ");
            //        break;  







        }





        #endregion



















    }
    }
}
