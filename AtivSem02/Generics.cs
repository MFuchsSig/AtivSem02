using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    class Generics
    {
        public class Alunos
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Id { get; set; }
            public static List<Alunos> ReturnAlunos()
            {

                List<Alunos> ListaAlunos = new List<Alunos>();
                Alunos aluno01 = new Alunos();
                Alunos aluno02 = new Alunos();
                Alunos aluno03 = new Alunos();
                Alunos aluno04 = new Alunos();
                Alunos aluno05 = new Alunos();
                Alunos aluno06 = new Alunos();
                Alunos aluno07 = new Alunos();
                Alunos aluno08 = new Alunos();
                Alunos aluno09 = new Alunos();
                Alunos aluno10 = new Alunos();

                aluno01.Nome = "Matheus Martins";
                aluno01.Idade = 21;
                aluno01.Id = "N01";

                ListaAlunos.Add(aluno01);

                aluno02.Nome = "Gabriela Castro";
                aluno02.Idade = 15;
                aluno02.Id = "N02";

                ListaAlunos.Add(aluno02);

                aluno03.Nome = "Pedro Martins";
                aluno03.Idade = 19;
                aluno03.Id = "N03";

                ListaAlunos.Add(aluno03);

                aluno04.Nome = "Danilo Sepuvida";
                aluno04.Idade = 33;
                aluno04.Id = "N04";

                ListaAlunos.Add(aluno04);

                aluno05.Nome = "Ian Faria";
                aluno05.Idade = 69;
                aluno05.Id = "N05";

                ListaAlunos.Add(aluno05);

                aluno06.Nome = "Leticia OLiveira";
                aluno06.Idade = 20;
                aluno06.Id = "N06";

                ListaAlunos.Add(aluno06);

                aluno07.Nome = "Mariana Fuchs";
                aluno07.Idade = 53;
                aluno07.Id = "N07";

                ListaAlunos.Add(aluno07);

                aluno08.Nome = "Mozaniel Pereira";
                aluno08.Idade = 25;
                aluno08.Id = "N08";

                ListaAlunos.Add(aluno08);


                aluno09.Nome = "Fernanda";
                aluno09.Idade = 35;
                aluno09.Id = "N09";

                ListaAlunos.Add(aluno09);


                aluno10.Nome = "Rodrigo Signorini";
                aluno10.Idade = 32;
                aluno10.Id = "N10";

                ListaAlunos.Add(aluno10);

                return ListaAlunos;
            }
            public static Alunos ReturnLinq(string id)
            {
                Alunos aluno = new Alunos();
                try
                {
                    var listaDeAlunos = ReturnAlunos();
                    aluno = listaDeAlunos.Find(i => i.Id == id);
                }
                catch
                {
                   
                    Console.WriteLine("Lista não encontrada");
                }
                return aluno;

            }
        }
    }
}
