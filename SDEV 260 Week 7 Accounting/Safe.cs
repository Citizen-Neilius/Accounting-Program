using System;
using System.Collections.Generic;
using System.Text;

namespace SDEV_260_Week_7_Accounting
{
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
    class Safe
    {
        double ckBal, svBal, loBal, reBal;
        public double CkBal { get => ckBal; set => ckBal = value; }
        public double SvBal { get => svBal; set => svBal = value; }
        public double LoBal { get => loBal; set => loBal = value; }
        public double ReBal { get => reBal; set => reBal = value; }
        public Safe(double CkBal, double SvBal, double LoBal, double ReBal)
        {
            this.CkBal = CkBal;
            this.SvBal = SvBal;
            this.LoBal = LoBal;
            this.ReBal = ReBal;
        }
    }
}
