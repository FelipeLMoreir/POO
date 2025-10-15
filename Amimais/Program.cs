using Amimais;
using System.Runtime.CompilerServices;

Animal[] animais;

Console.WriteLine("Quantos animais deseja cadastrar?");
int qtdAnimais = int.Parse(Console.ReadLine()!);

animais = new Animal[qtdAnimais];

for (int i = 0; i < qtdAnimais; i++)
{
    Console.WriteLine("Qual animal deseja? (1 - Cachorro / 2 - Gato / 3 - Leão) ");
    int tipoAnimal = int.Parse(Console.ReadLine()!);

    switch (tipoAnimal)
    {
        case 1:
            Console.WriteLine("Digite o nome do animal: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("");
            Console.WriteLine("Digite a idade do animal");
            int idade = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Cachorro cachorro = new Cachorro();

            cachorro.setNome(nome);
            cachorro.setIdade(idade);
            

            animais[i] = cachorro;

            Console.Clear();
            break;
        case 2:
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine()!;
            Console.WriteLine("");
            Console.WriteLine("Digite a idade do animal");
            idade = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Gato gato = new Gato();

            gato.setNome(nome);
            gato.setIdade(idade);

            animais[i] = gato;
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine()!;
            Console.WriteLine("");
            Console.WriteLine("Digite a idade do animal");
            idade = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Leao leao = new Leao();

            leao.setNome(nome);
            leao.setIdade(idade);

            animais[i] = leao;
            Console.Clear();
            break;
        default:
            break;
    }
}

for (int i = 0; i < qtdAnimais; i++)
{
    Console.WriteLine();
    animais[i].ExibirInfo();
    animais[i].EmitirSom();
    Console.WriteLine();
}
