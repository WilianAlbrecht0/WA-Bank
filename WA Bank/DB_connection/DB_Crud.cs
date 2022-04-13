using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA_Bank.DB_connection
{
    internal class DB_Crud
    {
        Connect con = new Connect();
        SqlCommand cmd = new SqlCommand();
        public string msg;

        public DB_Crud()
        {

        }

        //method
        public void Create(string name, string password, string cpf, string tell, string balance)
        {
            cmd.CommandText = "insert into Account(Nome,Cpf,Tell,Saldo,Senha) values ('" + name+"','"+ cpf +"','" + tell+"', '" + balance + "','"+password+"')";

            /*cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@cpf",cpf);
            cmd.Parameters.AddWithValue("@tell",tell);
            cmd.Parameters.AddWithValue("@balance",balance);
            cmd.Parameters.AddWithValue("@password",password); */

            try
            {
                cmd.Connection = con.OpenConection();
                cmd.ExecuteNonQuery();
                con.CloseConection();

                this.msg = "cadastro realizado com sucesso";
            }
            catch(SqlException)
            {
                msg = "erro ao se conectar ao banco dados";
            }
           
        }


        public void remove(string cpf, string password)
        {
            try
            {
                cmd.CommandText = "exec pcr_delete @cpf, @password";
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.Connection = con.OpenConection();

                cmd.ExecuteNonQuery();

                con.CloseConection();

            }catch(SqlException e)
            {
                this.msg = "nome ou senha incorretos";
            }

        }


    }
}
