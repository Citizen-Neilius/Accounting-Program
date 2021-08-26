using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Form1 : Form
    {
        Account NeilAct = new Account(1100011101, 110001000, 323500205, 102305050, "Neil Little"); //Constructor for acct numbers.
        Safe NeilSafe = new Safe(1004, 20305.20, 12412, 124155);
        Account TomAct = new Account(1100011102, 110001001, 323500206, 102305051, "Tom Clancy"); //Constructor for acct numbers.
        Safe TomSafe = new Safe(10042, 250305.20, 121412, 1155);
        Account TinaAct = new Account(1100011103, 110001002, 323500207, 102305052, "Tina Tequilla"); //Constructor for acct numbers.
        Safe TinaSafe = new Safe(100423, 20302345.20, 0, 12234155);
        Account TacoAct = new Account(1100011104, 110001003, 323500208, 102305053, "Taco DePaco"); //Constructor for acct numbers.
        Safe TacoSafe = new Safe(13, 45.20, 3499, 0);

        public Form1()
        {
            InitializeComponent();
        }


        public void Form1_Load(object sender, EventArgs e)
        {
        }
        


        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void selAct_Click(object sender, EventArgs e)
        {
            int userSel = userList.SelectedIndex;
            switch (userSel)
            {
                case 0:
                    NeilAct.disAct();
                    break;
            }
                


        }
    }
}
