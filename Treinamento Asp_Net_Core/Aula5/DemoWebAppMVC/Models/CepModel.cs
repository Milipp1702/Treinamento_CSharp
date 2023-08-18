namespace DemoWebAppMVC.Models;

public class CepModel
{
    public string Cep{get;set;} = null!;
    public string Estado{get;set;} = null!;
    public string Cidade{get;set;} = null!;
    public string Bairro{get;set;} = null!;
    public string Logradouro{get;set;} = null!;

    public static CepViewModel ParaViewModel(CepModel cepModel)
    {
        return new CepViewModel
        {
            Cep = cepModel.Cep,
            Estado = cepModel.Estado,
            Logradouro = cepModel.Logradouro,
            Bairro = cepModel.Bairro,
            Cidade = cepModel.Cidade
        };
    }

    public static CepModel ParaModel(CepViewModel cepViewModel)
    {
        return new CepModel
        {
            Cep = cepViewModel.Cep,
            Estado = cepViewModel.Estado,
            Logradouro = cepViewModel.Logradouro,
            Bairro = cepViewModel.Bairro,
            Cidade = cepViewModel.Cidade
        };
    }
}