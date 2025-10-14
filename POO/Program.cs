using POO;

Pessoa pessoa = new Pessoa();

pessoa.setNome("João");
pessoa.setIdade(25);
pessoa.setCPF("123.456.789-00");
pessoa.setAltura(1.75);

Console.WriteLine(pessoa.getNome());
Console.WriteLine(pessoa.getIdade());
Console.WriteLine(pessoa.getCPF());
Console.WriteLine(pessoa.getAltura());

Console.ReadKey();