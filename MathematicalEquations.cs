using System;

class MainClass {
   static void Main(string[] args)
        {
            int a = 1, b = 2;
            float c = 2.4f, d = 4.7f;

            a = getInteger();
            b = getInteger();
            c = getFloat();
            d = getFloat();

            displayHeading("Maths Demo");

            //addition with integers works as expected
            displayIntegerAddition(5, 4);
            displayIntegerAddition(a, b);
            Console.WriteLine();

            //Subtraction by integers can cause problems
            displayIntegerSubtraction(5, 4);
            displayIntegerSubtraction(a, b);
            Console.WriteLine();

            //multiplications with integers works as expected
            displayIntegerMultiplication(5, 4);
            displayIntegerMultiplication(a, b);
            Console.WriteLine();

            //dividing by floating point (decimal) values works better
            displayFloatDividing(5f, 4f);
            displayFloatDividing(c, d);
            Console.WriteLine();

            //multiplying by floating point (decimal) values works for decimal numbers
            displayFloatMultiplication(5f, 4f);
            displayFloatMultiplication(c, d);
            Console.WriteLine();

            pauseProgram();


        }// end procedure main

        static void displayIntegerAddition(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }// end procedure displayIntegerAddition

        static void displayIntegerSubtraction(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }// end procedure displayIntegerSubtraction

        static void displayIntegerMultiplication(int a, int b)
        {
            Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
        }// end procedure displayIntegerMultiplication

        static void displayFloatDividing(float c, float d)
        {
            Console.WriteLine("{0} / {1} = {2}", c, d, c / d);
        }// end procedure displayFloatDividing

        static void displayFloatMultiplication(float c, float d)
        {
            Console.WriteLine("{0} x {1} = {2}", c, d, c * d);
        }// end procedure displayFloatMultiplication

        static void displayHeading(string heading)
        {
            Console.WriteLine();
            Console.WriteLine(heading);
            Console.WriteLine();
            Console.WriteLine();
        }// end procedure displayHeading

        static int getInteger()
        {
            Console.Write("Please enter a whole number: ");
            return Convert.ToInt16(Console.ReadLine());
        }//end function getInteger

        static float getFloat()
        {
            Console.Write("Please enter a decimal number: ");
            return Convert.ToSingle(Console.ReadLine());
        }//end function getFloat

        static void pauseProgram()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Please press \"enter\" to continue");
            Console.ReadLine();
        }
        
}