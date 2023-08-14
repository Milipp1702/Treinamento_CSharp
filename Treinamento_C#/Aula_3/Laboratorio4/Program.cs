namespace Laboratorio4;
class Program
{
    static void Main(string[] args)
    {
        ContaCorrente minhaConta = new ContaCorrente(340,"Milena");
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Depositar(100);
        Console.WriteLine(minhaConta.Saldo);
        minhaConta.Sacar(50);
        Console.WriteLine("Saldo: "+minhaConta.Saldo);
        Console.WriteLine("Nome do Titular: "+minhaConta.NomeTitular);
        Console.WriteLine("Data da Criação: "+minhaConta.DataCriacao.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")));
        Console.WriteLine("Saldo médio: "+minhaConta.SaldoMedio);
    }
}
