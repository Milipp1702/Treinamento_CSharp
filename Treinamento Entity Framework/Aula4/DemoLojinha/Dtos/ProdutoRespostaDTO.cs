namespace DemoLojinha.Dtos;

using DemoLojinha.Models;

public class ProdutoRespostaDTO
{
    public int Id{get;set;}
    public string Nome{get;set;} = null!;
    public int Descricao{get;set;}
    public string PrecoUnitario{get;set;} = null!;

    public static ProdutoRespostaDTO DeModelParaDTO(Produto model)
    {
        return new ProdutoRespostaDTO{
            Id = model.Id,
            Nome = model.Nome,
            Descricao = model.Descricao,
            PrecoUnitario = $"{model.PrecoUnitario/100M:C}"
        };
    }
}