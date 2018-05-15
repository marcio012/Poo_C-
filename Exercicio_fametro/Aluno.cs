using System;

namespace Exercicio_fametro
{
    class Aluno
    {
        public string nomeAluno; 
        public int matricula;
        public int cpf;

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
