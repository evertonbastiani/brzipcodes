using Newtonsoft.Json;
using System.Net.Http.Headers;
using web.ceps.Response;
using web.ceps.Services.Interface;

namespace web.ceps.Services
{
    public class CepService : ICepService
    {
        private const string _urlCepBase = "https://localhost:7165/Cep/";
        public async Task<IEnumerable<CepResponse>> BuscarCep(string cep)
        {
            IEnumerable<CepResponse> response = new List<CepResponse>();
            using (HttpClient httpClient = new HttpClient())
            {
                string url = $"{_urlCepBase}BuscarCep?cep={cep}";
                httpClient.BaseAddress = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var responseApi = await httpClient.GetAsync(httpClient.BaseAddress);
                var responseStr = await responseApi.Content.ReadAsStringAsync();

                response = JsonConvert.DeserializeObject<IEnumerable<CepResponse>>(responseStr);

            }

            return response;
        }

        public async Task<IEnumerable<string>> ListarCidades(string UF)
        {
            IEnumerable<string> response = new List<string>();
            using (HttpClient httpClient = new HttpClient())
            {
                string url = $"{_urlCepBase}ListarCidades?UF={UF}";
                httpClient.BaseAddress = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var responseApi = await httpClient.GetAsync(httpClient.BaseAddress);
                var responseStr = await responseApi.Content.ReadAsStringAsync();

                response = JsonConvert.DeserializeObject<IEnumerable<string>>(responseStr);

            }

            return response;
        }

        public async Task<IEnumerable<string>> ListarUnidadesFederativas()
        {
            IEnumerable<string> response = new List<string>();
            using (HttpClient httpClient = new HttpClient())
            {
                string url = $"{_urlCepBase}ListarUnidadesFederativas";
                httpClient.BaseAddress = new Uri(url);
                httpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                var responseApi = await httpClient.GetAsync(httpClient.BaseAddress);
                var responseStr = await responseApi.Content.ReadAsStringAsync();

                response = JsonConvert.DeserializeObject<IEnumerable<string>>(responseStr);

            }

            return response;
        }
    }
}
