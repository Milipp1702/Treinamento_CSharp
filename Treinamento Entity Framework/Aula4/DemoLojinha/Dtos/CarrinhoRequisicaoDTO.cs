namespace DemoLojinha.Dtos;

using System.ComponentModel.DataAnnotations;

public class CarrinhoRequisicaoDTO
{
    [Required(ErrorMessage = "Id Cliente é obrigatório")]
    public int? IdCliente{get;set;}
    public IEnumerable<ItemCarrinhoRequisicaoDTO> Itens {get;set;} = null!;
}

public class ItemCarrinhoRequisicaoDTO
{
    [Required(ErrorMessage = "Id Produto é obrigatório")]
    public int? IdProduto{get;set;}
    [Required(ErrorMessage = "Quantidade é obrigatória")]
    [Range(1,10, ErrorMessage = "No Mínimo 1 e no Máximo 10 unidades do produto")]
    public int? Quantidade{get;set;}
}