public abstract class Conta
{
    private decimal saldo;
    private string titular;

    public decimal Saldo
    {
        get { return saldo; }
    }   
    public string Titular
    {
        get { return titular; }
    }
    public abstract string Id
    {
        get;
    }

    public Conta(string t)
    {
        titular = t;
    }

    public virtual void Depositar(decimal valor)
    {
        if(valor > 0)
        {
            saldo += valor;
        }
        else
        {
            Console.WriteLine("Saldo para depósito deve ser positivo!");
        }
    }

    public virtual void Sacar(decimal valor)
    {
        if(valor < saldo)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Valor para saque deve ser menor do que o saldo!");
        }
    }
    
    public override string? ToString()
    {
        return "=========================\nSaldo: "+this.saldo+"\nTitular: "+this.titular;
    }
}