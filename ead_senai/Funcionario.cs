using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead_senai
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public double SalarioBase { get; set; }
        public Funcionario(string nome, int cpf, double salarioBase)
        {
            Nome = nome;
            CPF = cpf;
            SalarioBase = salarioBase;
        }
        public virtual double CalcularSalarioFinal()
        {
            return SalarioBase;
        }
        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, CPF: {CPF}, Salário Final: {CalcularSalarioFinal():C}");
        }
    }
}
