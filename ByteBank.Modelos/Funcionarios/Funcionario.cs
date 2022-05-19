using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionários
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        public Funcionario (double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário.");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }
        public abstract void AumentarSalario();
        internal protected abstract double GetBonificacao();
    }
}
