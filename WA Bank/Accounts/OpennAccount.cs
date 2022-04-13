using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA_Bank.Accounts
{
    internal class OpennAccount : Account
    {
        public double OpeningBalance { get ; set; } 

        //construtor 
        public OpennAccount(string name, string password, string cpf, string tell, double blance) : base(name, password, cpf, tell)
        {
              this.OpeningBalance = blance;
        }

        //metodos
        public void CreateAccount()
        {

        }

    }
}
