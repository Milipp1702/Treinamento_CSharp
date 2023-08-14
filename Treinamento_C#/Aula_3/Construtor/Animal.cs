public class Animal
{
    private int anoDeNascimento;
    private decimal altura, peso;
    private string nome;

    public Animal() : this("Sem nome",-1,-1,-1){}

    public Animal(string _nome, int _anoDeNascimento, decimal _altura, decimal _peso)
    {
        anoDeNascimento = _anoDeNascimento;
        altura = _altura;
        peso = _peso;
        nome = _nome;
    }

    public virtual void EmiteSom()
    {
        Console.WriteLine("O som do animal");
    }

    public void algumaCoisa()
    {
        Console.WriteLine("Mostra alguma coisa a partir da classe Animal!");
    }

    public virtual string toString()
    {
        return ("===============\nNome: "+nome+"\nNascimento: "+anoDeNascimento+"\nPeso: "+peso+"\nAltura: "+altura);
    }
}