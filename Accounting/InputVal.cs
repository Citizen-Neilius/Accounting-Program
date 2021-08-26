using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting
{
    class InputVal  // Class for input validations 
    {
        public string tempI;                        // holder for readline.
        public static bool doubleTrue = false;     // True if input is a double
        public static double testI;             // Output of TryParse
        public void inputVal(string uInput)         // parameter of user input 
        {
            this.tempI = uInput;      

            if (double.TryParse(tempI, out testI) == true) // if the user's input is a double, then :
            {
                if (testI > -1 && testI < 10000000)
                doubleTrue = true;
                else
                {
                    doubleTrue = false;
                    Console.WriteLine("Please enter a number!");
                    inputVal(Console.ReadLine());  // restart the method.
                }
            
            }
            else
            {
                doubleTrue = false;
                Console.WriteLine("Please enter a number between 0 and 1000000!");
                inputVal(Console.ReadLine());  // restart the method.
            }
        }
    
    }
}
/* Neil Little 
    October 4th 2019
    SDEV 260 - Week 6 homework. 

    Assignment Descriptions: Refactor the exercise program that you created last week to 
    include instructor feedback. Add at least one new piece of functionality of your choosing. 
    -Also, add the following:
        -Constructors
        -Getters and Setters, as needed.
        -Validation in setters, as needed
        -Formatting in getters, as needed.
    -Add one example of a nested class, or a static member, your choice.
    -Include a document that outlines the changes that you made since last week. 
    Any unresolved bugs and any special instructions that you think your instructor 
    will need to evaluate your program.

    I added formatting using a getter to for the calories so it displays only 2 decimal points.

    I added a constructor that greets the user with "Greetings!" at the beginning of the code.

    I added input validation using setters to the age  input.

    I changed the class Heartrate to a static method to satisfy the "static member" requisite.      
    */
