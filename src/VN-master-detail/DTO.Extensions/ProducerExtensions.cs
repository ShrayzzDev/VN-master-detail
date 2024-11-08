using DTO.Producer;
using Model.Producer;
using System.Runtime.CompilerServices;
using System.Text;

namespace DTO.Extensions
{
    public static class ProducerExtensions
    {
        public static SimpleProducer ToModel(this SimpleProducerDTO dto)
        {
            return new SimpleProducer(
                dto.id,
                dto.name,
                dto.type,
                dto.description
            );
        }

        public static SimpleProducer[] ToModels(this SimpleProducerDTO[] dtos)
        {
            var models = new SimpleProducer[dtos.Length];
            for (int i = 0; i < dtos.Length; ++i)
            {
                models[i] = dtos[i].ToModel();
            }
            return models;
        }

        public static string ToString(this SimpleProducerDTO[] producers)
        {
            var sb = new StringBuilder();
            foreach ( var producer in producers ) 
            {
                sb.AppendLine("----------");
                sb.AppendLine(producer.ToString());
            }
            return sb.ToString();
        }
        public static string ToString(this DetailedProducerDTO[] producers)
        {
            var sb = new StringBuilder();
            foreach (var producer in producers)
            {
                sb.AppendLine("----------");
                sb.AppendLine(producer.ToString());
            }
            return sb.ToString();
        }
    }
}
