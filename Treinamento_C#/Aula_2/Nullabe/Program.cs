namespace Aula_2;
class Program
{
    static void Main(string[] args)
    {
        string first = "xuxu";
        string second = string.Empty;
        int third = 3;
        DateTime? date = null;

        //O ? deixa colocar um valor null na variavel, onde antes não era possivel
        Console.WriteLine("Valores das Variáveis");
        Console.WriteLine(" O Valor de first é:"+first);
        Console.WriteLine(" O Valor de second é:"+second);
        Console.WriteLine(" O Valor de third é:"+third);
        Console.WriteLine(" O Valor de date é:"+date);

        int? v1 = 0;
        int? v2 = null;
        int? v3 = default;
        int? v4 = new();

        Console.WriteLine("Valores das Variáveis v");
        Console.WriteLine(" O Valor de v1 é:"+v1);
        Console.WriteLine(" O Valor de v2 é:"+v2);
        Console.WriteLine(" O Valor de v3 é:"+v3);
        Console.WriteLine(" O Valor de v4 é:"+v4);

        DateTime? d1 = null;
        DateTime? d2 = default;
        DateTime? d3 = new();

        Console.WriteLine("Valores das Variáveis d");
        Console.WriteLine(" O Valor de d1 é:"+d1);
        Console.WriteLine(" O Valor de d2 é:"+d2);
        Console.WriteLine(" O Valor de d3 é:"+d3);
    }
}
