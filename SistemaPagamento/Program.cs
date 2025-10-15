using SistemaPagamento;

Console.WriteLine("Qual opção de pagamento deseja utilizar?");
int opcaoPagamento = int.Parse(Console.ReadLine()!);

for (int i = 0; i < opcaoPagamento; i++)
{
    if(opcaoPagamento == 1)
    {
        PagamentoBoleto pagamentoBoleto = new PagamentoBoleto(); 

        pagamentoBoleto.ProcessarPagamento();
    }
    else
    {
        PagamentoCartaoCredito pagamentoCartaoCredito = new PagamentoCartaoCredito();

        pagamentoCartaoCredito.ProcessarPagamento();
    }
}