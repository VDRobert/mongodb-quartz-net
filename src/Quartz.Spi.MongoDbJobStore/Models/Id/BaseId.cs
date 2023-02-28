using MongoDB.Bson.Serialization.Attributes;

namespace Quartz.Spi.MongoDbJobStore.Models.Id
{
    [BsonKnownTypes(typeof(FiredTriggerId), typeof(LockId), typeof(SchedulerId),
        typeof(CalendarId), typeof(PausedTriggerGroupId), typeof(TriggerId), 
        typeof(JobDetailId), typeof(BaseKeyId))]
    internal abstract class BaseId
    {
        public string InstanceName { get; set; }
    }
}