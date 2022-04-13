using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA_Bank.Accounts
{
    internal class Account
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string Tell { get; set; }   
        public string Balance { get; set; }

        //constructor

        public Account()
        {

        }

        public Account(string name,string password, string cpf, string tell)
        {
            this.Name = name;
            this.Cpf = cpf;
            this.Password = password;
            this.Tell = tell;
        }
        public Account(string name, string password, string cpf, string tell,string balance)
        {
            this.Name = name;
            this.Password = password;
            this.Cpf = cpf;
            this.Balance = balance;
            this.Tell = tell;
        }

        //metodos


    }
}
