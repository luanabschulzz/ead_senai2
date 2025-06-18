using ead_senai;

Gerente gerente = new Gerente("Ana Silva", 123456789, 5000.00);
Estagiario estagiario = new Estagiario("Lucas Santos", 987654321, 1200.00);
FuncionarioComum funcionarioComum = new FuncionarioComum("Mariana Costa", 456789123, 3000.00);

Console.WriteLine("Dados dos Funcionários");

gerente.ExibirDados();
Console.WriteLine();

estagiario.ExibirDados();
Console.WriteLine();

funcionarioComum.ExibirDados();
Console.WriteLine();
