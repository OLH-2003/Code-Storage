using System;

namespace Switch_programs
{
    class Program // initialises the program
    {
        static void Main(string[] args) // runs the main procedure 
        {
            int Age;  
            string ticket;
            double costing;

            displayOptions();
            Age = getAge();
            ticket = getType();
            costing = calculate(Age, ticket);
            displayResult(costing, Age, ticket);  // calls the function displayResult(score)
            pauseProgram();  // calls the program pauseProgram()
        }// end procedure main

        static void displayOptions()
        {
            Console.WriteLine("                         Single  Return");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("Children under 16:      |£2.00  |£3.50");
            Console.WriteLine("Adult:                  |£3.50  |£7.00");
            Console.WriteLine("Concession (60 or over) |£1.75  |£3.00");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("");
            
        }

        static int getAge() 
        {
            int tempAge;  

            Console.Write("Please enter your age : ");
            tempAge = Convert.ToInt16(Console.ReadLine());  
            return tempAge;
        }

        static string getType() 
        {
          string tempType;  

            Console.Write("Please enter ticket type (single/ return) : ");
            tempType = Convert.ToString(Console.ReadLine());  
            return tempType;
        }
        
        static double calculate(int Age, string ticket)
        {
          double tempCosting;
        
          switch(ticket){
                case "single":  if(Age < 5)
                                  tempCosting = 0;
                                else if(Age < 16)
                                  tempCosting = 2.00;
                                else if(Age >= 60)
                                  tempCosting = 1.75;
                                else
                                  tempCosting = 3.50;
                break;
                case "return":  if(Age < 5)
                                  tempCosting = 0;
                                else if(Age < 16)
                                  tempCosting = 3.50;
                                else if(Age >= 60)
                                  tempCosting = 3.00;
                                else
                                  tempCosting = 7.00;
                break;
                default: tempCosting = 0;
                break;

          }
          return tempCosting;
          
        }
        
        static void displayResult(double costing, int Age, string ticket)
        {
          
          Console.WriteLine("______________________________________");
          
          if(costing == 3.5){
            Console.WriteLine("Ticket chosen - {0}", ticket);
            Console.WriteLine("Age - {0} years", Age);
            if (costing == 0)
            Console.WriteLine("Total Price - Free");
            else
            Console.WriteLine("Total Price - £{0}0", costing);
          }
          else{
            Console.WriteLine("Ticket chosen - {0}", ticket);
            Console.WriteLine("Age - {0} years", Age);
            if (costing == 0)
            Console.WriteLine("Total Price - Free");
            else
            Console.WriteLine("Total Price - £{0}", costing);
          }
        }
        
        static void pauseProgram()  // runs the procedure pauseProgram
        {
            Console.WriteLine();  // empty line for aesthetics
            Console.WriteLine();  // empty line for aesthetics
            Console.WriteLine("Please press \"enter\" to continue");  // displays the line shown
            Console.WriteLine();  // empty line for aesthetics
            Console.ReadLine();  // 
        }// end procedure pauseProgram 

    } // end class program
}