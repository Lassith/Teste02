using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Analise
{
    //Cadastro do Professor
    public class InstrumentoDal
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public string marca { get; set; }
        public string quantidade { get; set; }

        public void Create(InstrumentoDal instrumento)
        {
            SqlConnection conn = new SqlConnection("Data Source=GRU0539703W10-1;Initial Catalog=Gig;User ID=sa;Password=123456");
            conn.Open();

            string cmdSql = ("insert Professores values ('" + instrumento.id + "','" + instrumento.nome + "','" + instrumento.tipo + "','" + instrumento.marca + "','" + instrumento.quantidade + "')");

            SqlCommand cmd = new SqlCommand(cmdSql, conn);
            cmd.ExecuteNonQuery();
        }

        //Atualiza na base de dados
        public void Update (InstrumentoDal instrumento)
        {
            SqlConnection conn = new SqlConnection("Data Source=GRU0539703W10-1;Initial Catalog=Gig;User ID=sa;Password=123456");
            conn.Open();

            string cmdSql = ("insert Instrumentos values ('" + instrumento.id + "','" + instrumento.nome + "','" + instrumento.tipo + "','" + instrumento.marca + "','" + instrumento.quantidade + "')");

            SqlCommand cmd = new SqlCommand(cmdSql, conn);
            cmd.ExecuteNonQuery();
        }

        public void Remove(int id)
        {

            SqlConnection conn = new SqlConnection("Data Source=GRU0539703W10-1;Initial Catalog=Gig;User ID=sa;Password=123456");
            conn.Open();

            StringBuilder cmdSQL = new StringBuilder();
            cmdSQL.Append("delete from Produto where id= " + id);

            SqlCommand cmd = new SqlCommand(cmdSQL.ToString(), conn);

            cmd.ExecuteNonQuery();


        }


    }
}
