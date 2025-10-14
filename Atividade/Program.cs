using Atividade;

Pessoa[] pessoa = new Pessoa[3];

for (int i = 0; i < pessoa.Length; i++)
{
    pessoa[i] = new Pessoa();

    Console.WriteLine($"Digite o nome da pessoa {i + 1}:");
    pessoa[i].setNome(Console.ReadLine()!);
    Console.WriteLine($"Digite o sobrenome da pessoa {i + 1}:");
    pessoa[i].setSobrenome(Console.ReadLine()!);
    Console.WriteLine($"Digite a idade da pessoa {i + 1}:");
    pessoa[i].setIdade(int.Parse(Console.ReadLine()!));
    Console.WriteLine($"Digite o sexo da pessoa {i + 1}(M/F):");
    pessoa[i].setSexo(char.Parse(Console.ReadLine()!));
    Console.WriteLine($"Digite a altura da pessoa {i + 1}:");
    pessoa[i].setAltura(double.Parse(Console.ReadLine()!));
    Console.Clear();
}

for (int i = 0; i < pessoa.Length; i++)
{
    pessoa[i].ExibirAtributos();
}

