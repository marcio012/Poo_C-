using System;
// using System.


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
            // aluno.cpf = int.Parse(Console.ReadLine());
            aluno.cpf = Console.ReadLine();

            Console.WriteLine("Você digitou: " + aluno);
            
            Console.ReadLine();


            // iniciando com o construtor 
            // passando por parametro o nome e matricula.

            Aluno aluno2 = new Aluno("Humberto Maia", 1234455);
            Aluno aluno3 = new Aluno("João das condongas", "123445533");

            Console.WriteLine("Você cadastrou um novo aluno: " + aluno2);
            Console.WriteLine("Você cadastrou um novo aluno: " + aluno3);
        }
    }
}
