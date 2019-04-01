using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Analise
{
    public class AlunoDal
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }

        //Cadastro do Aluno
        public void Create(AlunoDal aluuno)
        {

            SqlConnection conn = new SqlConnection("Data Source=GRU0539703W10-1;Initial Catalog=Gig;User ID=sa;Password=123456");
            conn.Open();

            string cmdSql = ("insert into Alunos values ('"+ aluuno.id +"','"+aluuno.nome+"','"+aluuno.rg +"','"+aluuno.cpf+"')");

            SqlCommand cmd = new SqlCommand(cmdSql, conn);

            cmd.ExecuteNonQuery();
        }

        //Atualiza na base de dados
        public void Update(AlunoDal aluuno)
        {


            SqlConnection conn = new SqlConnection("Data Source=GRU0539703W10-1;Initial Catalog=Gig;User ID=sa;Password=123456");
            conn.Open();

            string cmdSql = ("update Alunos set nome = '"+nome+"', rg = '"+rg+"', cpf = '"+cpf+"' where id = '"+id+"'");

            SqlCommand cmd = new SqlCommand(cmdSql, conn);

            cmd.ExecuteNonQuery();

        }

        public void Remove(string aluuno)
        {

            SqlConnection conn = new SqlConnection("Data Source=GRU0539703W10-1;Initial Catalog=Gig;User ID=sa;Password=123456");
            conn.Open();

            StringBuilder cmdSQL = new StringBuilder();
            cmdSQL.Append("delete from Produto where id= " + aluuno);

            SqlCommand cmd = new SqlCommand(cmdSQL.ToString(), conn);

            cmd.ExecuteNonQuery();


        }

      
    }
}
