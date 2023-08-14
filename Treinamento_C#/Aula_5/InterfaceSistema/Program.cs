namespace InterfaceSistema;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new("Milena",21);
        Pessoa p2 = new Pessoa("Milena",21);
        Pessoa p3 = p1;

        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());

        Console.WriteLine("p1 é igual a p2? "+(p1==p2));
        Console.WriteLine("p1 é igual a p3? "+(p1==p3));
        Console.WriteLine("p3 é igual a p2? "+(p3==p2));

        Console.WriteLine("p1 é igual a p2? (EQUALS)"+(p1.Equals(p2)));
        Console.WriteLine("p1 é igual a p3? (EQUALS)"+(p1.Equals(p3)));
        Console.WriteLine("p3 é igual a p2? (EQUALS)"+(p3.Equals(p2)));
    }
}
