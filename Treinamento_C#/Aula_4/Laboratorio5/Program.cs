using System.Drawing;
namespace Laboratorio5;
class Program
{
    static void Main(string[] args)
    {
        //exerc 1
        Circulo circ1 = new Circulo();
        Console.WriteLine(circ1);
        Circulo circ2 = new Circulo(2.4, 5, 3);
        Console.WriteLine(circ2);
        CirculoColorido circ3 = new CirculoColorido();
        Console.WriteLine(circ3); 
        Console.WriteLine(circ3.CentroX);
        Console.WriteLine(circ3.CentroY);
        CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
        Console.WriteLine(circ4); 

        //exerc 2
        CirculoColoridoPreenchido circ5 = new CirculoColoridoPreenchido(1.8, 2, 7, "rosa",Color.Lavender);
        Console.WriteLine(circ5); 
        Console.WriteLine("\n");
        //exerc 3
        List<Circulo> listaCirc = new List<Circulo>();
        Circulo c1 = new Circulo(5, 2, 7);
        CirculoColorido c2 = new CirculoColorido(5, 2, 7,"rosa");
        CirculoColoridoPreenchido c3 = new CirculoColoridoPreenchido(5, 2, 7,"rosa",Color.Yellow);
        listaCirc.Add(c1);
        listaCirc.Add(c2);
        listaCirc.Add(c3);
        listaCirc.ForEach(c => Console.WriteLine(c.ToString()));
    }
}
