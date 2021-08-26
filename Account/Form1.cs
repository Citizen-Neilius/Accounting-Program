/* Neil Little   11 OCT 2019
 * SDEV 260 Week 7 homework. 
 * 
 * //You have been tasked by your lead engineer to design part of a baking system.
//Your code will manage checking accounts, savings accounts, loan accounts and 
//retirement accounts.
//Your system will use a base class called Account from which */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class FormAcct : Form
    {
        


        public int selI;//variable that mirrors the listbox selected index.
        int selT;  //assigns and integer to the user's selected check box.  used to add to "x" to make an array coordinate.
        public int x;          // x is used to select the appropriate array element.  it is a combination of selected user (0,4,8,12) and selT
        public string temp;                 //Vars for number validation
        public string tempI;                        // holder for readline.  input valildation
        public static bool doubleTrue = false;     // True if input is a double   input validation
        public static double testI;             // Output of TryParse   inputvalidation

        
        private double[,] arrAcct = new double[16, 2]    //2D arry for account data
{
            {1001,4145.00},  // Creating an array with 16 columns, 2 rows.
            {1002,23525 },
            {1003,15665},
            {1004,136350 }, // each user has four values, 1 for each account.  
            {2001,145.00},
            {2002,525},
            {2003,155666 },
            {2004,6350 },
            {3001,55.00 },
            {3002,666625},
            {3003,156 },
            {3004,1346350},
            {4001,55.00 },
            {4002,666625},
            {4003,156 },
            {4004,1346350}
};

        public double[,] ArrAcct { get => arrAcct; set => arrAcct = value; }  // Getter and setters for account array.
        public class Window
        {
        }
        public FormAcct()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBoxAcct_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public static string textLabel;

        void buttonOK_Click(object sender, EventArgs e)  
        {
            selI = listBoxAcct.SelectedIndex;  //Assigns user index to selI 0,1,2, or 3
            
            {
             
                AccountCl NeilAct = new AccountCl(1100011101, 110001000, 323500205, 102305050, "Neil Little"); //Constructor for acct numbers.
                AccountCl TomAct = new AccountCl(1100011102, 110001001, 323500206, 102305051, "Tom Clancy"); //Constructor for acct numbers.
                AccountCl TinaAct = new AccountCl(1100011103, 110001002, 323500207, 102305052, "Tina Tequilla"); //Constructor for acct numbers.
                AccountCl TacoAct = new AccountCl(1100011104, 110001003, 323500208, 102305053, "Taco DePaco"); //Constructor for acct numbers.
                selI = listBoxAcct.SelectedIndex;
                DerivedClass derivedClass = new DerivedClass(1,1,1,1,textBox1.Text,"Something new");//Constructor values for derived class
                label3.Text = derivedClass.DerivedString;

                // The If statements:  selI is the selected user.  If 0 (Neil) textLabel1 displays all the account data, account numbers and balance.
                if (selI == 0)
                {
                    x = 0; // each user has 4 accounts, Neil's is 0 to 3, Tom 4 to 7.  etc
                    LoanBalance neillo = new LoanBalance()
                    {
                        FirstName = "Neil", LastName = "Little", Balance = ArrAcct[2, 1]/2,LoanName = "boat"
                    };
                    LoanBalance neilcar = new LoanBalance()
                    {
                        FirstName = "Neil",
                        LastName = "Little",
                        Balance = ArrAcct[2, 1] / 2,
                        LoanName = "Car"
                    };
                    neilcar.VirtualM();  //my virtual method

                    label4.Text = neilcar.Name+ "\n " + "Loan balance \n" + neilcar.LoanName + " " + neilcar.Balance+"\n" +
                         ""+ neillo.LoanName + " " + neillo.Balance;

                    textLabel = Convert.ToString("Account Holder: \t" + NeilAct.naAct + "\nChecking Account #         " + NeilAct.ckAct+ "\nChecking balance" +
          "         $" + ArrAcct[0, 1] + "\n\nSavings Account #        " + NeilAct.svAct + "\nSavings Balance:       $" + ArrAcct[1,1] + "\n\nLoan Account" +
          " #         " + NeilAct.loAct + "\nTotal Debt       $" + ArrAcct[2, 1] + "\n\nRetirement Acct #       " + NeilAct.reAct + "\nRetirement Balance:       $" + ArrAcct[3, 1]);
                        
                }
                else if (selI == 1)
                {
                    x = 4;
                    LoanBalance tomlo = new LoanBalance()
                    {
                        FirstName = "tom",
                        LastName = "lancy",
                        Balance = ArrAcct[6, 1] / 2,
                        LoanName = "boat"
                    };
                    LoanBalance tomcar = new LoanBalance()
                    {
                        FirstName = "tom",
                        LastName = "Clancy",
                        Balance = ArrAcct[6, 1] / 2,
                        LoanName = "Car"
                    };
                    tomcar.VirtualM();
                    label4.Text = tomcar.Name + "\n " + "Loan balance \n" + tomcar.LoanName + " " + tomcar.Balance + "\n" +
                         "" + tomlo.LoanName + " " + tomlo.Balance;
                    textLabel = Convert.ToString("Account Holder: \t" + TomAct.naAct + "\nChecking Account #         " + TomAct.ckAct + "\nChecking balance" +
        "         $" + ArrAcct[4, 1] + "\n\nSavings Account #        " + TomAct.svAct + "\nSavings Balance:       $" + ArrAcct[5, 1] + "\n\nLoan Account" +
        " #         " + TomAct.loAct + "\nTotal Debt       $" + ArrAcct[6, 1] + "\n\nRetirement Acct #       " + TomAct.reAct + "\nRetirement Balance:       $" + ArrAcct[7, 1]);
                }
                else if (selI == 2)
                {
                    x = 8;
                    LoanBalance tinalo = new LoanBalance()
                    {
                        FirstName = "tina",
                        LastName = "Tequilla",
                        Balance = ArrAcct[10, 1] / 2,
                        LoanName = "boat"
                    };
                    LoanBalance tinacar = new LoanBalance()
                    {
                        FirstName = "tina",
                        LastName = "Tequilla",
                        Balance = ArrAcct[10, 1] / 2,
                        LoanName = "Car"
                    };
                    tinacar.VirtualM();
                    label4.Text = tinacar.Name + "\n " + "Loan balance \n" + tinacar.LoanName + " " + tinacar.Balance + "\n" +
                         "" + tinalo.LoanName + " " + tinalo.Balance;
                    textLabel = Convert.ToString("Account Holder: \t" + TinaAct.naAct + "\nChecking Account #         " + TinaAct.ckAct + "\nChecking balance" +
        "         $" + ArrAcct[8, 1] + "\n\nSavings Account #        " + TinaAct.svAct + "\nSavings Balance:       $" + ArrAcct[9, 1] + "\n\nLoan Account" +
        " #         " + TinaAct.loAct + "\nTotal Debt       $" + ArrAcct[10, 1] + "\n\nRetirement Acct #       " + TinaAct.reAct + "\nRetirement Balance:       $" + ArrAcct[11, 1]);
                }
                else if (selI == 3)
                {
                    x = 12;
                    LoanBalance tacolo = new LoanBalance()
                    {
                        FirstName = "Taco",
                        LastName = "DePaco",
                        Balance = ArrAcct[14, 1] / 2,
                        LoanName = "boat"
                    };
                    LoanBalance tacocar = new LoanBalance()
                    {
                        FirstName = "Taco",
                        LastName = "Depaco",
                        Balance = ArrAcct[14, 1] / 2,
                        LoanName = "Car"
                    };
                    tacocar.VirtualM();
                    label4.Text = tacocar.Name + "\n " + "Loan balance \n" + tacocar.LoanName + " " + tacocar.Balance + "\n" +
                         "" + tacolo.LoanName + " " + tacolo.Balance;
                    textLabel = Convert.ToString("Account Holder: \t" + TacoAct.naAct + "\nChecking Account #         " + TacoAct.ckAct + "\nChecking balance" +
        "         $" + ArrAcct[12, 1] + "\n\nSavings Account #        " + TacoAct.svAct + "\nSavings Balance:       $" + ArrAcct[13, 1] + "\n\nLoan Account" +
        " #         " + TacoAct.loAct + "\nTotal Debt       $" + ArrAcct[14, 1] + "\n\nRetirement Acct #       " + TacoAct.reAct + "\nRetirement Balance:       $" + ArrAcct[15, 1]);
                    
                }
                button1.Enabled = true;  // enabled depositing or withdrawal.
             
            }
            labelAct.Text = textLabel;
            //labelAct.Refresh();

        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDeposit.Checked == false)  // determining if the user wished to deduct or add to the selected account
                button1.Text = "Withdrawal";
            else
                button1.Text = "Deposit";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)

            // selT is to select account type:  selT will be added to x (user) to determine the array coordinate to pull from.
        {
            if (radioCk.Checked == true)
                selT = 0;
            if (radioSv.Checked == true)
                selT = 1;
            if (radioLo.Checked == true)
                selT = 2;

            if (RadioRe.Checked == true)
                selT = 3;
            if (double.TryParse(textBox1.Text, out testI) == true && testI > -1 && testI < 10000000) // if the user's input is a double, then :

                //deposit or withdrawal from the selected coordinates
            {
                double tempN;                
                x = x + selT;   // x is 0,4,8,12 for user and selT is 0,1,2,3 for account type added together to create a unique array coordinate
                label2.Text = Convert.ToString(x);
                if (radioDeposit.Checked == true)
                {
                    tempN = (ArrAcct[x, 1] + (Convert.ToDouble(textBox1.Text)));  
                    label1.Text = "Your new balance is $" + Convert.ToString(tempN)+ "\n Please select an account and press OK";
                    ArrAcct[x, 1] = tempN;  // assigning the value of the 2D array to tempN 
                    x = 0;                                                                                 //reseting x
                    buttonOK_Click(sender, e);   //runs the same actions as pressing the "OK" button
                    button1.Enabled = false;      // user must select press the "ok" button again to deposit or withdrawal again.
                }

                if (radioWithdrawal.Checked == true)
                {
                    tempN = (ArrAcct[x, 1] - (Convert.ToDouble(textBox1.Text)));
                    label1.Text = "Your new balance is $" + Convert.ToString(tempN) + "\n Please select an account and press OK";
                    ArrAcct[x, 1] = tempN;
                    x = 0;
                    buttonOK_Click(sender, e);
                    button1.Enabled = false;
                }

            }
            else
            {
                doubleTrue = false;
                MessageBox.Show("Please enter a valid number.");  //input validation.  
            }
            x = 0;

        }

        private void radioCk_Click(object sender, EventArgs e)
        {
        }

        private void radioLo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLo.Checked == true)
            {
                radioDeposit.Text = "Borrow"; radioWithdrawal.Text = "Pay Bill";
                if (radioDeposit.Checked == true)
                    button1.Text = "Borrow";
                else
                    button1.Text = "Pay Bill";
            }
            else
            {
                radioDeposit.Text = "Deposit"; radioWithdrawal.Text = "Withdrawal";
                if (radioDeposit.Checked == true)
                    button1.Text = "Deposit";
                else
                    button1.Text = "Withdrawal";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
