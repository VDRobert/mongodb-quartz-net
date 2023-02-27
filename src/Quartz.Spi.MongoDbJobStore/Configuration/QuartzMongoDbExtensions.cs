using System;
using Quartz;

namespace Quartz.Spi.MongoDbJobStore.Configuration
{
    public static class QuartzMongoDbExtensions
    {
        public static void UseMongoDb(this SchedulerBuilder.PersistentStoreOptions options, Action<QuartzMongoDbOptions> configure)
        {
            configure?.Invoke(new QuartzMongoDbOptions(options));
        }

        public static void UseMongoDbPersistantStorage(
            this IServiceCollectionQuartzConfigurator configurator, Action<QuartzMongoDbOptions> configure)
        {

            configurator.UsePersistentStore<MongoDbJobStore>(options =>
            {
                options.UseMongoDb(configure);
            });
        }
    }
}
