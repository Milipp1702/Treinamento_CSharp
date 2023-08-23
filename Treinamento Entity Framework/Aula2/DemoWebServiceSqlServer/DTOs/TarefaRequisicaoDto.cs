namespace DemoWebServiceSqlServer.DTOs;

using System.ComponentModel.DataAnnotations;

public class TarefaRequisicaoDto
{
    [Required(ErrorMessage = "Nome é obrigatório")]
    [MaxLength(30, ErrorMessage = "Nome no máximo 30 caracteres")]
    public string? Nome {get;set;}
    [MaxLength(150, ErrorMessage = "Descrição no máximo 150 caracteres")]
    public string? Descricao {get;set;}
}