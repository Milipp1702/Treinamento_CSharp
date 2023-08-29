namespace DemoLojinha.Dtos;

using DemoLojinha.Models;

public class ItemRespostaDTO
{
    public int IdProduto{get;set;}
    public string NomeProduto{get;set;} = null!;
    public string ValorUnitario{get;set;} = null!;
    public int Quantidade {get;set;}
    public string SubTotal{get;set;} = null!;
    public static ItemRespostaDTO DeModelParaDTO(Item model)
    {
        return new ItemRespostaDTO{
            IdProduto = model.ProdutoId,
            NomeProduto = model.Produto.Nome,
            ValorUnitario = $"{model.Produto.PrecoUnitario/100M:C}",
            Quantidade = model.Quantidade,
            SubTotal = $"{model.Quantidade * model.Produto.PrecoUnitario /100M : C}"
        };
    }
}