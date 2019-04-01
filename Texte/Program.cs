using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texte
{
    class Program
    {
        static void Main(string[] args)
        {
            App.Analise.AlunoDal objAluno = new App.Analise.AlunoDal();

            objAluno.id = 452;
            objAluno.nome = "Sabrina";
            objAluno.rg = "02585265985";
            objAluno.cpf = "1548225859";

            objAluno.Update(objAluno);

            Console.WriteLine("Aluno Atualizado!");

            Console.ReadKey();



            //App.Analise.ProfessoresDAL objprofessor = new App.Analise.ProfessoresDAL();

            //objprofessor.id = 256;
            //objprofessor.nome = "Xavier";
            //objprofessor.cpf = "15428625985";
            //objprofessor.rg = "125452862";
            //objprofessor.materia = "Matematica";

            //objprofessor.Create(objprofessor);

            //Console.WriteLine("Dados Cadastrados!");

            //Console.ReadKey();

            //App.Analise.InstrumentoDal objinstrumento = new App.Analise.InstrumentoDal();

            //objinstrumento.id = 588;
            //objinstrumento.nome = "Flauta 785";
            //objinstrumento.tipo = "sopro";
            //objinstrumento.marca = "Yamaha";
            //objinstrumento.quantidade = "5";

            //objinstrumento.Create(objinstrumento);

            //Console.WriteLine("Instrumento Cadastrado!");

            //Console.ReadKey();




            




        }
        
    }
}
