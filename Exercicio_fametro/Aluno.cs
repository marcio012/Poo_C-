using System;
// using System.Globaization;

namespace Exercicio_fametro
{
    class Aluno
    {
        public string nomeAluno; 
        public int matricula;
        public string cpf;

        // construtor
        public Aluno()
        {

        }

        // construtor 
        public Aluno(string nomeAluno, int matricula) 
        {
            this.nomeAluno = nomeAluno;
            this.matricula = matricula;
        }

        // construtor 2
        public Aluno(string nomeAluno, string cpf)
        {
            this.nomeAluno = nomeAluno;
            this.cpf = cpf;
        }



        public override string ToString()
        {
            return nomeAluno
                + ", "
                + matricula
                + ", "
                + cpf
                + ".";
        }

       

    }
}
