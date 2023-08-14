using System;

namespace Laboratorio4;
class ContaCorrente 
{
    private decimal saldo, saldoMedio;
    private DateTime dataCriacao;
    private string nomeTitular;
    private int cont;

    public ContaCorrente(decimal _val, string _nomeTitular)
    {
        saldo = _val;
        nomeTitular = _nomeTitular;
        dataCriacao = DateTime.Now;
    }

    public string NomeTitular
    {   
        get { return nomeTitular; }
    }

    public DateTime DataCriacao
    {   
        get { return dataCriacao; }
    }

    public decimal Saldo
    {   
        get { return saldo; }
    }

    public decimal SaldoMedio
    {   
        get 
        {
            if(cont > 0)
            {
                return saldoMedio / cont; 
            } 
            return saldo;
        }
    }

    public void Depositar(decimal val)
    {
        if(val > 0)
        {
            saldo = saldo + val;
            contarSaldoMedio();
        }
        else
        {
            Console.WriteLine("Valor para depósito deve ser maior que 0!");
        }
    }

    private void contarSaldoMedio(){
        cont++;
        saldoMedio += saldo;
    }

    public void Sacar(decimal val)
    {
        if(val < saldo)
        {
            saldo = saldo - val;
            contarSaldoMedio();
        }
        else
        {
            Console.WriteLine("Saldo Indisponível para saque!");
        }
    }
}