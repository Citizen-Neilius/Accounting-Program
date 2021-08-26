using System;
using System.Collections.Generic;
using System.Text;
/* Neil Little   11 OCT 2019
 * SDEV 260 Week 7 homework. 
 * 
 * //You have been tasked by your lead engineer to design part of a baking system.
//Your code will manage checking accounts, savings accounts, loan accounts and 
//retirement accounts.
//Your system will use a base class called Account from which */

namespace Account
{
    class AccountCl   // Class account is the frame work for the Account names and account numbers
  
    {
        public int ckAct, svAct, loAct, reAct;
        public string naAct;

        public AccountCl(int ckAct, int svAct, int loAct, int reAct, string naAct) //The constructor for AccountCL.
            //allows account numbers for checking, savings, loan, and retirement to be created.
        {
            this.ckAct = ckAct;
            this.svAct = svAct;
            this.loAct = loAct;
            this.reAct = reAct;
            this.naAct = naAct;
        }
    }
}
