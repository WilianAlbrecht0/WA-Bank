using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WA_Bank.Forms;

namespace WA_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbCreate_Click(object sender, EventArgs e)
        {
            CreateAccount acc = new CreateAccount();
            acc.Visible = true;
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
