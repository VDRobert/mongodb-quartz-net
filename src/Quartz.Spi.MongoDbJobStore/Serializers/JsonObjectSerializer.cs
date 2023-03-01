using System.Text;
using System.Text.Json;
using Quartz.Spi;

namespace Quartz.Simpl
{
    public class JsonObjectSerializer : IObjectSerializer
    {
        private readonly JsonSerializerOptions _options;

        public JsonObjectSerializer(JsonSerializerOptions? options = null)
        {
            _options = options ?? new JsonSerializerOptions();
        }
        public void Initialize()
        {
        }

        public byte[] Serialize<T>(T obj) where T : class
        {
            return Encoding.UTF8.GetBytes(JsonSerializer.Serialize(obj, _options));
        }

        public T? DeSerialize<T>(byte[] data) where T : class
        {
            return JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(data), _options);
        }
    }
}