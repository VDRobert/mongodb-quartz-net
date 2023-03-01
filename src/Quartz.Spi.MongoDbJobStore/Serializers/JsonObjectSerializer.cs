using System.Text;
using Newtonsoft.Json;
using Quartz.Spi;

namespace Quartz.Simpl
{
    public class JsonObjectSerializer : IObjectSerializer
    {
        JsonSerializerSettings serializerSettings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

        public void Initialize()
        {
        }

        /// <summary>
        /// Serializes given object as bytes 
        /// that can be stored to permanent stores.
        /// </summary>
        /// <param name="obj">Object to serialize.</param>
        public byte[] Serialize<T>(T obj) where T : class
        {
            string serializedData = JsonConvert.SerializeObject(obj, serializerSettings);
            return Encoding.UTF8.GetBytes(serializedData);
        }

        /// <summary>
        /// Deserializes object from byte array presentation.
        /// </summary>
        /// <param name="data">Data to deserialize object from.</param>
        public T DeSerialize<T>(byte[] data) where T : class
        {
            string str = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<T>(str, serializerSettings);
        }

    }
}