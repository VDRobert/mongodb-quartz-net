using Quartz.Impl;

namespace Quartz.Spi.MongoDbJobStore.Configuration
{
    public class QuartzMongoDbOptions : SchedulerBuilder.StoreOptions
    {

        public QuartzMongoDbOptions(PropertiesHolder? parent = null) : base(parent ?? SchedulerBuilder.Create())
        {
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
    }
}
