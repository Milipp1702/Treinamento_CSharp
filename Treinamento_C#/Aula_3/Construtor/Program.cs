namespace Construtor;
class Program
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente();
        Console.WriteLine("Nome: "+c.Nome);
        Console.WriteLine("Limite do Cliente: "+c.consultaClienteID());
        Console.WriteLine("Consulta UID do cliente: "+c.consultaLimite());

        Data d2 = new(8,8,2023);
        d2.print();

        Data d1 = new();
        d1.print();
        
        d1 = new(d2);
        d1.print();

        d1 = new(8,8,"2024");
        d1.print();

        Data.imprimeAlgo();

        Data d3 = d1+d2;
        Console.WriteLine("D1");
        d1.print();
        Console.WriteLine("D2");
        d2.print();
        Console.WriteLine("D3");
        d3.print();

        Console.WriteLine("D3 com soma no dia:");
        d3 = d1+2;
        d3.print();

        //Classe animal q irá ser implementada depois
        Animal a = new();
        Console.WriteLine(a.toString()+"\n======");

        Gato g = new("Bengal");
        Console.WriteLine(g.toString());
        g.EmiteSom();

        g.algumaCoisa();
    }
}
