using MongoDB.Bson.Serialization.Attributes;

namespace Quartz.Spi.MongoDbJobStore.Models.Id
{
    [BsonKnownTypes(typeof(TriggerId), typeof(JobDetailId))]
    internal abstract class BaseKeyId : BaseId
    {
        public string Name { get; set; }
        public string Group { get; set; }
    }
}