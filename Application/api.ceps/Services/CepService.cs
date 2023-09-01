using Amazon.Runtime.Internal;
using MongoDB.Bson;
using MongoDB.Driver;

namespace api.ceps.Services
{
    public class CepService : ICepService
    {
        private readonly IMongoCollection<api.ceps.Model.ceps> _cepCollection;

        public CepService()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var mondoDatabase = mongoClient.GetDatabase("brceps");

            _cepCollection = mondoDatabase.GetCollection<api.ceps.Model.ceps>("ceps");

        }

        public async Task<IEnumerable<Model.ceps>> BuscarCep(string cep)
        {
            return await _cepCollection.Find(x => x.cep == cep).ToListAsync();
        }

        public async Task<IEnumerable<string>> ListarCidades(string UF)
        {
            UF = UF.ToUpper();
            var filter = new BsonDocument(new BsonElement("uf", UF));
            return await _cepCollection.Distinct<string>("cidade",filter).ToListAsync();
        }

        public async Task<IEnumerable<string>> ListarUnidadesFederativas()
        {
            var filter = new BsonDocument();
            return await _cepCollection.Distinct<string>("uf", filter).ToListAsync();
        }
    }
}
