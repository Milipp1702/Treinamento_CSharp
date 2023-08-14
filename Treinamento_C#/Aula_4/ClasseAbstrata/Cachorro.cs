public class Cachorro : Animal
{
    public Cachorro()
    {
        Console.WriteLine("Construtor do cachorro.");
    }

    public override void emitirSom()
    {
        Console.WriteLine("Auau");
    }
}