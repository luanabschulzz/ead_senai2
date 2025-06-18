using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ead_senai
{
    public class Gerente : Funcionario
    {
        private double Bonus = 2000.00;
        public Gerente(string nome, int cpf, double salarioBase) : base(nome, cpf, salarioBase) { }
        public override double CalcularSalarioFinal()
        {
            return SalarioBase + Bonus;
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"[Gerente] Nome: {Nome}, CPF: {CPF}, Salário Final: {CalcularSalarioFinal():C}");
        }
    }
}
