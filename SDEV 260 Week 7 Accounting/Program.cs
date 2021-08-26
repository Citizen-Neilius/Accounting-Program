using System;

namespace SDEV_260_Week_7_Accounting
    //You have been tasked by your lead engineer to design part of a baking system.
    //Your code will manage checking accounts, savings accounts, loan accounts and 
    //retirement accounts.Your system will use a base class called Account from which 
    //the others are derived.Your code shall have basic functionality in each class to
    //demonstrate that you understand the concept of inheritance.Make sure that you use 
    //  proper object-oriented techniques and include getters, setters, constructors and
    //    other object-oriented techniques that are appropriate.Include a document that
    //    discusses any problems you had with creating the program, known bugs, and any
    //    instructions that you think your instructor will need when evaluating your program.

{
    class Program
    {
        static void Main(string[] args)

        {
            Account NeilAct = new Account(1100011101, 110001000, 323500205, 102305050, "Neil Little"); //Constructor for acct numbers.
            Safe NeilSafe = new Safe(1004, 20305.20, 12412, 124155);
            Account TomAct = new Account(1100011102, 110001001, 323500206, 102305051, "Tom Clancy"); //Constructor for acct numbers.
            Safe TomSafe = new Safe(10042, 250305.20, 121412, 1155);
            Account TinaAct = new Account(1100011103, 110001002, 323500207, 102305052,"Tina Tequilla"); //Constructor for acct numbers.
            Safe TinaSafe = new Safe(100423, 20302345.20, 0, 12234155);
            Account TacoAct = new Account(1100011104, 110001003, 323500208, 102305053, "Taco DePaco"); //Constructor for acct numbers.
            Safe TacoSafe = new Safe(13, 45.20, 3499, 0);
            

        }
    }
}
