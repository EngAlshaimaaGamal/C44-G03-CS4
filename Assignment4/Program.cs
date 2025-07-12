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



        }
    }
}
