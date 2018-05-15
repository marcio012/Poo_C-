using System;

namespace Exercicio_fametro
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno.");
            Console.Write("Nome: ");
            aluno.nomeAluno = Console.ReadLine();

            Console.Write("Matricula: ");
            aluno.matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu Cpf.: ");
            aluno.cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: " + aluno);
            
            Console.ReadLine();
        }
    }
}
