using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead_senai
{
    public class FuncionarioComum : Funcionario
    {
        public FuncionarioComum(string nome, int cpf, double salarioBase) : base(nome, cpf, salarioBase)
        {

        }
        public override double CalcularSalarioFinal()
        {
            return SalarioBase;
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"[Funcionário Comum] Nome: {Nome}, CPF: {CPF}, Salário Final: {CalcularSalarioFinal():C}");
        }
    }
}
