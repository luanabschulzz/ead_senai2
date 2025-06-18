using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead_senai
{
    public class Estagiario : Funcionario
    {
        private double Desconto = 0.2;
        public Estagiario(string nome, int cpf, double salarioBase) : base(nome, cpf, salarioBase)
        {

        }
        public override double CalcularSalarioFinal()
        {
            return SalarioBase - Desconto;
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"[Estagiário] Nome: {Nome}, CPF: {CPF}, Salário Final: {CalcularSalarioFinal():C}");
        }
    }
}
