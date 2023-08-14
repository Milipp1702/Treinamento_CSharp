public class Cliente
{
    public const string tipo = "Pessoa";
    private String nome;
    private decimal limiteCredito;
    private uint clienteID;

    public Cliente(){
        nome = "João Ninguem";
        limiteCredito = -1;
        clienteID = 1;
    }

    public string Nome{
        get {return nome;}
        set{nome = value;}
    }

    public decimal consultaLimite(){
        return limiteCredito;
    }

    public decimal consultaClienteID(){
        return clienteID;
    }
}