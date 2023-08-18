namespace DemoWebAppMVC.Models;

using System.ComponentModel.DataAnnotations;

public class CepViewModel
{
    [RegularExpression(@"^\d{8}$", ErrorMessage = "Cep deve ter exatamante 8 dígitos!")]
    public string Cep{get;set;} = null!;
    
    [RegularExpression(@"^[A-Z]{2}$", ErrorMessage = "Estado deve ser uma sigla com 2 letras maiúsculas!")]
    public string Estado{get;set;} = null!;

    [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres!")]
    public string Cidade{get;set;} = null!;

    [StringLength(40, ErrorMessage = "Cidade deve ter no máximo 40 caracteres!")]
    public string Bairro{get;set;} = null!;

    [StringLength(70, ErrorMessage = "Cidade deve ter no máximo 70 caracteres!")]
    public string Logradouro{get;set;} = null!;
}