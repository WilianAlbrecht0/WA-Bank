using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA_Bank.DB_connection;

namespace WA_Bank.Accounts
{
    internal class OpennAccount : Account
    {
        public string OpeningBalance { get ; set; } 

        //construtor 
        public OpennAccount(string name, string password, string cpf, string tell, string balance) : base(name, password, cpf, tell, balance)
        {
 
        }

        //metodos
        public void CreateAccount()
        {
            DB_Crud db = new DB_Crud();
            db.Create(this.Name, this.Password, this.Cpf, this.Tell, this.Balance);
        }

    }
}
