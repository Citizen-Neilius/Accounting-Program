using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class BaseLoans
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Name { get; set; }
    public virtual void VirtualM()
    {
        Name = FirstName + " " + LastName;
    }

    public abstract double GetLoanBalance();
    public abstract string GetLoanName();
}
    class LoanBalance : BaseLoans
    {
        public double Balance { get; set; }

        public override double GetLoanBalance()
        {
            return this.Balance;
        }
    public string LoanName { get; set; }
    public override string GetLoanName()
    {
        return this.LoanName;
    }
}

    


