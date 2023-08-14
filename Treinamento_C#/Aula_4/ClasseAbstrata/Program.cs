namespace ClasseAbstrata;
class Program
{
    static void Main(string[] args)
    {
        Animal a =new Gato();
        Console.WriteLine(a.ToString());
        a.emitirSom();

        a = new Cachorro();
        Console.WriteLine(a.ToString());
        a.emitirSom();
    }
}
