namespace api.ceps.Services
{
    public interface ICepService
    {
        Task<IEnumerable<api.ceps.Model.ceps>> BuscarCep(string cep);
        Task<IEnumerable<string>> ListarCidades(string UF);
        Task<IEnumerable<string>> ListarUnidadesFederativas();
    }
}
