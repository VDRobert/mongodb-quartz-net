using Quartz.Impl;

namespace Quartz.Spi.MongoDbJobStore.Configuration
{
    public class QuartzMongoDbOptions : SchedulerBuilder.StoreOptions
    {
        public QuartzMongoDbOptions() : base(SchedulerBuilder.Create())
        {
            this.SerializerType = "json";
        }

        public QuartzMongoDbOptions(PropertiesHolder parent) : base(parent)
        {
            this.SerializerType = "json";
        }

        public string? InstanceName
        {
            set => SetProperty(StdSchedulerFactory.PropertySchedulerInstanceName, value);
            get => Properties.Get(StdSchedulerFactory.PropertySchedulerInstanceName);
        }

        public string? InstanceNameId
        {
            set => SetProperty(StdSchedulerFactory.PropertySchedulerInstanceId, value);
            get => Properties.Get(StdSchedulerFactory.PropertySchedulerInstanceId);
        }

        public string? ConnectionString
        {
            set => SetProperty($"{StdSchedulerFactory.PropertyJobStorePrefix}.{StdSchedulerFactory.PropertyDataSourceConnectionString}", value);
            get => Properties.Get($"{StdSchedulerFactory.PropertyJobStorePrefix}.{StdSchedulerFactory.PropertyDataSourceConnectionString}");
        }

        public string? CollectionPrefix
        {
            set => SetProperty($"{StdSchedulerFactory.PropertyJobStorePrefix}.collectionPrefix", value);
            get => Properties.Get($"{StdSchedulerFactory.PropertyJobStorePrefix}.collectionPrefix");
        }

        public string? DatabaseName
        {
            set => SetProperty($"{StdSchedulerFactory.PropertyJobStorePrefix}.databaseName", value);
            get => Properties.Get($"{StdSchedulerFactory.PropertyJobStorePrefix}.databaseName");
        }

        public string? SerializerType
        {
            set => SetProperty($"quartz.serializer.type", value);
            get => Properties.Get($"quartz.serializer.type");
        } 
    }
}
