namespace DemoLojinha.Models;

public class Item
{
    public int Quantidade{get;set;}
    //relacionamento com o Produto
    public Produto Produto{get;set;} = null!;
    public int ProdutoId {get;set;}
    public Pedido Pedido{get;set;} = null!;
    public int PedidoId {get;set;}
}