namespace DemoCepRest.Models;

using DemoCepRest.DTOs;

public class CepModel
{
    public string Cep{get;set;} = null!;
    public string Estado{get;set;} = null!;
    public string Cidade{get;set;} = null!;
    public string Bairro{get;set;} = null!;
    public string Logradouro{get;set;} = null!;

    public static CepDTO ParaDTO(CepModel model)
    {
        return new CepDTO
        {
            Cep = model.Cep,
            Estado = model.Estado,
            Cidade = model.Estado,
            Bairro = model.Bairro,
            Logradouro = model.Logradouro
        };
    }
}