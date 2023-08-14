namespace Classes;
class Program
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente();
        Console.WriteLine(c);
        //Acessando uma constante
        //Console.WriteLine(c.tipo);  -> causou erro de compilação
        Console.WriteLine(Cliente.tipo);

        //acessando um método publico da classe Cliente
        c.Saudacao();
        //Cliente.saudacao(); -> Causou um erro de compilação

        Console.WriteLine("O limite de crédito é: "+ c.consultaLimite());
        Console.WriteLine("Adicionando R$ 50,00 de limite: ");
        c.AumentarLimite(50M);
        Console.WriteLine("O limite de crédito é: "+ c.consultaLimite());

        //Explorando paramtros com metodo out
        int a = 10;
        int b;

        /*Não funciona pois sem o out, a variavel sem valor pré definido não é aceita na passagem de parametro
        Console.WriteLine("O valor de a é: "+ a);
        c.MetodoNormal(a,b);
        Console.WriteLine("Depois da chamada com o out:");
        Console.WriteLine("O valor de a é: "+ a);
        Console.WriteLine("O valor de b é: "+ b);
        */
        
        Console.WriteLine("O valor de a é: "+ a);
        c.MetodoOut1(a,out b);
        Console.WriteLine("Depois da chamada com o out:");
        Console.WriteLine("O valor de a é: "+ a);
        Console.WriteLine("O valor de b é: "+ b);

        Console.WriteLine("\nAntes da chamada do método com ref:");
        Console.WriteLine("O valor de a é: "+ a);
        c.MetodoRef1(a,ref b);
        Console.WriteLine("Depois da chamada com o ref:");
        Console.WriteLine("O valor de a é: "+ a);
        Console.WriteLine("O valor de b é: "+ b);

        Console.WriteLine("\nMétodo com nro dinâmico de parâmetros:");
        int[] minhaLista = new int[4]{1,2,3,4};
        c.MetodoParam(minhaLista);

        //manipulação de propriedade
        Console.WriteLine("\nNome do cliente é: "+c.Nome);
        c.Nome = "Milena Petersen";
        Console.WriteLine("Nome do cliente é: "+c.Nome);
    }
}
