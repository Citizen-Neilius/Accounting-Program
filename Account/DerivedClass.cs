using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class DerivedClass : AccountCl //Class that simply shows inheritance etc.
    {
        public string DerivedString;
        public DerivedClass(int ckAct, int svAct, int loAct, int reAct, string naAct,string somethingNew): base(ckAct,svAct,loAct,reAct,naAct) 
            //Constructor for Derived class using "base".
        {
            DerivedString = " This message is from a class derived from\nAccountCL.  This class shows inheritance,constructors, and \"base\" \n" +
                "here is the var naAct defined by the textbox: " + naAct + "\n and and new constructor, unique to the derived class\n " + somethingNew;
                
        }
    }
}
