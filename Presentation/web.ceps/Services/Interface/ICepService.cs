using web.ceps.Response;

namespace web.ceps.Services.Interface
{
    public interface ICepService
    {
        Task<IEnumerable<CepResponse>> BuscarCep(string cep);
        Task<IEnumerable<string>> ListarCidades(string UF);
        Task<IEnumerable<string>> ListarUnidadesFederativas();
    }
}

