using GerenciamentoFunc;
using System.Collections.Concurrent;

Funcionario[] funcionarios;

Console.WriteLine("quantos funcionários deseja cadastrar? ");
int qtdFuncionarios = int.Parse(Console.ReadLine()!);

funcionarios = new Funcionario[qtdFuncionarios];

for (int i = 0; i < qtdFuncionarios; i++)
{
    Console.WriteLine("O funcionario é CLT ou PJ? (1 - PJ ou 2 - CLT)");
    int tipoFunc = int.Parse(Console.ReadLine()!);

    if (tipoFunc == 1)
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("");
        Console.WriteLine("Digite seu slário base: ");
        double salarioBase = double.Parse(Console.ReadLine()!);
        Console.WriteLine("");
        Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine()!);
        Console.WriteLine("");
        Console.WriteLine("Digite o valor por hora: ");
        double valorHora = double.Parse(Console.ReadLine()!);
        Console.WriteLine("");
        
        FuncionarioPJ funcionarioPJ = new FuncionarioPJ();

        funcionarioPJ.setNome(nome);
        funcionarioPJ.setSalarioBase(salarioBase);
        funcionarioPJ.setHorasTrabalhadas(horasTrabalhadas);
        funcionarioPJ.setValorHora (valorHora);

        funcionarios[i] = funcionarioPJ;
        Console.Clear();
    }
    else
    {

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("");
        Console.WriteLine("Digite seu slário base: ");
        double salarioBase = double.Parse(Console.ReadLine()!);
        Console.WriteLine("");
        Console.WriteLine("Digite o valor do seu bonus: ");
        int bonus = int.Parse(Console.ReadLine()!);
        Console.WriteLine("");

        FuncionarioCLT funcionarioCLT = new FuncionarioCLT();

        funcionarioCLT.setNome(nome);
        funcionarioCLT.setSalarioBase(salarioBase);
        funcionarioCLT.setBonus(bonus);

        funcionarios[i] = funcionarioCLT;
        Console.Clear();
    }
}

for (int i = 0; i < qtdFuncionarios; i++)
{
    Console.WriteLine();
    funcionarios[i].ExibirInfo();
    Console.WriteLine();
}