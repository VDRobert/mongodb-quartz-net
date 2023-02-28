using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using Quartz.Spi;

namespace Quartz.Simpl
{
    /// <summary>
    /// Default object serialization strategy that uses <see cref="BinaryFormatter" /> 
    /// under the hood.
    /// </summary>
    /// <author>Marko Lahma</author>
    public class DefaultObjectSerializer : IObjectSerializer
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions = new();

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
            string serializedData = JsonSerializer.Serialize(obj, _jsonSerializerOptions);
            return Encoding.UTF8.GetBytes(serializedData);
        }

        /// <summary>
        /// Deserializes object from byte array presentation.
        /// </summary>
        /// <param name="data">Data to deserialize object from.</param>
        public T DeSerialize<T>(byte[] data) where T : class
        {
            string str = Encoding.UTF8.GetString(data);
            return JsonSerializer.Deserialize<T>(str, _jsonSerializerOptions)!; 
        }
    }
}
