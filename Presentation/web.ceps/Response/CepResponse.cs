namespace web.ceps.Response
{
    public class CepResponse
    {
        public string Id { get; set; }
        public string cep { get; set; } = null!;
        public string tipo_logradouro { get; set; } = null!;
        public string logradouro { get; set; } = null!;
        public string cidade { get; set; } = null!;
        public string uf { get; set; } = null!;
        public string codigo_ibge { get; set; } = null!;
        public string bairro { get; set; } = null!;
    }
}
