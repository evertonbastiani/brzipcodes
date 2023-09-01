using MongoDB.Bson.Serialization.Attributes;

namespace api.ceps.Model
{
    public class ceps
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
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
