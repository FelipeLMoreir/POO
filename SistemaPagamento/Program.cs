using SistemaPagamento;

Console.WriteLine("Digite o valor a ser pago:");
var valor = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Qual opção de pagamento deseja utilizar?");
var opcaoPagamento = int.Parse(Console.ReadLine()!);

//for (int i = 0; i < opcaoPagamento; i++)
//{
    if(opcaoPagamento == 1)
    {
        PagamentoBoleto pagamentoBoleto = new PagamentoBoleto(); 

        pagamentoBoleto.ProcessarPagamento(DateTime.Now, valor);
    }
    else if (opcaoPagamento == 2)
    {
        PagamentoCartaoCredito pagamentoCartaoCredito = new PagamentoCartaoCredito();

        pagamentoCartaoCredito.ProcessarPagamento(DateTime.Now, valor);
    }
    else
    {
        Console.WriteLine("forma de pagamento inválida!");
    }
//}