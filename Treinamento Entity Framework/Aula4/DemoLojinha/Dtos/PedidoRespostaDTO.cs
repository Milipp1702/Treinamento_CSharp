namespace DemoLojinha.Dtos;

using DemoLojinha.Models;

public class PedidoRespostaDTO
{
    public int Id{get;set;}
    public string DataEmissao{get;set;} = null!;
    public string NomeCliente{get;set;} = null!;
    public string ValorTotal{get;set;} = null!;
    public IEnumerable<ItemRespostaDTO> Itens{get;set;} = null!;

    public static PedidoRespostaDTO DeModelParaDTO(Pedido model)
    {
        var total = model.Itens.Sum(item => item.Quantidade * item.Produto.PrecoUnitario / 100M);
        return new PedidoRespostaDTO{
            Id = model.Id,
            DataEmissao = model.DataEmissao.ToShortDateString(),
            NomeCliente = model.cliente.Nome,
            ValorTotal = $"{total:C}",
            Itens = model.Itens.Select(ItemRespostaDTO.DeModelParaDTO)
            //mesma coisa q
            //Itens = model.Itens.Select(item => ItemRespostaDTO.DeModelParaDTO(item))
        };
    }
}