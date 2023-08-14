public class Gato : Animal
{
    private string raca;

    public Gato(string _raca) : base("Feijão",2020,5,20)
    {
        raca = _raca;
    }

    public override void EmiteSom(){
        Console.WriteLine("Miau");
    }

    public override string toString(){
        return base.toString()+"\nA raça do gato é: "+raca;
    }
}