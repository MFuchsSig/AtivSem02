using System;
using System.Threading;
using static AtivSem02.Generics.Alunos;
namespace AtivSem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------------------- Insira um ID para para realizar a pesquisa ex: N01 ----------------------- ");
            string id = Console.ReadLine();

            var aluno = ReturnLinq(id);
            if (aluno != null)
            {
                Console.WriteLine("ALUNO ENCONTRADO");
                Console.WriteLine("\n Nome: {0}   \n Idade: {1} anos  \n Id aluno: {2}", aluno.Nome, aluno.Idade, aluno.Id);

                return;

            }
            else
            {
                Console.WriteLine("ALUNO NÃO ENCONTRADO");

            }
        }
    }

}

