using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Analise
{
    //Cadastro do Professor
    public class ProfessoresDAL
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string materia { get; set; }

        public void Create(ProfessoresDAL professor)
        {
            SqlConnection conn = new SqlConnection("Data Source=GRU0539703W10-1;Initial Catalog=Gig;User ID=sa;Password=123456");
            conn.Open();

            string cmdSql = ("insert Professores values ('"+professor.id+"','"+professor.nome+"','"+professor.rg+"','"+professor.cpf+"','"+professor.materia+"')");

            SqlCommand cmd = new SqlCommand(cmdSql, conn);
            cmd.ExecuteNonQuery();
        }

        //Atualiza na base de dados
        public void Update(AlunoDal professor)
        {


            SqlConnection conn = new SqlConnection("Data Source=GRU0539703W10-1;Initial Catalog=Gig;User ID=sa;Password=123456");
            conn.Open();

            string cmdSql = ("insert into Aluno values ('" + professor.id + "','" + professor.nome + "','" + professor.rg + ",'" + professor.cpf + "')");

            SqlCommand cmd = new SqlCommand(cmdSql, conn);

            cmd.ExecuteNonQuery();

        }

        public void Remove(string professor)
        {

            SqlConnection conn = new SqlConnection("Data Source=GRU0539703W10-1;Initial Catalog=Gig;User ID=sa;Password=123456");
            conn.Open();

            StringBuilder cmdSQL = new StringBuilder();
            cmdSQL.Append("delete from Produto where id= " + professor);

            SqlCommand cmd = new SqlCommand(cmdSQL.ToString(), conn);

            cmd.ExecuteNonQuery();


        }

        
    }
}
