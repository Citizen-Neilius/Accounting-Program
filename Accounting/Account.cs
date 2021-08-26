using System;
using System.Collections.Generic;
using System.Text;
//You have been tasked by your lead engineer to design part of a baking system.
//Your code will manage checking accounts, savings accounts, loan accounts and 
//retirement accounts.
//Your system will use a base class called Account from which 
//the others are derived.Your code shall have basic functionality in each class to
//demonstrate that you understand the concept of inheritance.Make sure that you use 
//  proper object-oriented techniques and include getters, setters, constructors and
//    other object-oriented techniques that are appropriate.Include a document that
//    discusses any problems you had with creating the program, known bugs, and any
//    instructions that you think your instructor will need when evaluating your program.

namespace Accounting
{
    class Account:Form1
    {
        public int ckAct, svAct, loAct, reAct;
        public string naAct;
        public Account( int ckAct, int svAct, int loAct, int reAct,string naAct)
        {
            this.ckAct = ckAct;
            this.svAct = svAct;
            this.loAct = loAct;
            this.reAct = reAct;
            this.naAct = naAct;
        }
        public void disAct()
        {
            AccountDis.Text = ("Account holder: \t\t" + naAct + "\nChecking account #:\t\t" + ckAct + "\n Balance:\t\t");
        }
    }
}
