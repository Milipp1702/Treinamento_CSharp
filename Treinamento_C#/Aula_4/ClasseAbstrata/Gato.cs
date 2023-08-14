public class Gato : Animal
{
    public Gato()
    {
        Console.WriteLine("Construtor do gato");
    }

    public override void emitirSom()
    {
        Console.WriteLine("Miau");
    }
}