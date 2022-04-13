using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WA_Bank.Accounts;

namespace WA_Bank.Forms
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btbCreate_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string cpf = txbCpf.Text;
            string tell = txbTell.Text;
            string balance = txbBalance.Text;
            string password = txbPassword.Text;
            string rPassword = txbRPassword.Text;

            if (password == rPassword)
            {
                OpennAccount acc = new OpennAccount(name, password,cpf,tell, balance);
                acc.CreateAccount();
            }
            else
            {
                MessageBox.Show("Senha não conferem");
            }
        }
    }
}
