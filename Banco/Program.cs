using Banco;
using System.Drawing;

Console.WriteLine("Você deseja sacar ou depositar?");
string opcao = Console.ReadLine()!;

if  (opcao == "sacar" || opcao == "Sacar" || opcao == "SACAR")
{
    ContaBancária saque = new ContaBancária();
    Console.WriteLine("Digite o quanto deseja sacar: ");
    decimal valor = decimal.Parse(Console.ReadLine()!);
    saque.Sacar(valor);
}
else if (opcao == "depositar" || opcao == "Depositar" || opcao == "DEPOSITAR")
{
    ContaBancária depositar = new ContaBancária();
    Console.WriteLine("Digite o quanto deseja depositar: ");
    decimal valor = decimal.Parse(Console.ReadLine()!);
    depositar.Depositar(valor);
}
else
{
    ContaBancária saldo = new ContaBancária();
    saldo.getSaldo();
}