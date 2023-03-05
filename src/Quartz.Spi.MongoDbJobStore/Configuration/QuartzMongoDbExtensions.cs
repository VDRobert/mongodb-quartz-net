using System;

namespace Quartz.Spi.MongoDbJobStore.Configuration
{
    public static class QuartzMongoDbExtensions
    {
        public static void UseMongoDb(this SchedulerBuilder.PersistentStoreOptions options, Action<QuartzMongoDbOptions>? configure = null)
        {
            var quartzMongoDbOptions = new QuartzMongoDbOptions(options);
            configure?.Invoke(quartzMongoDbOptions);
        }

        public static void UseMongoDbPersistantStorage(
            this IServiceCollectionQuartzConfigurator configurator, Action<QuartzMongoDbOptions>? configure = null)
        {

            configurator.UsePersistentStore<MongoDbJobStore>(options =>
            {
                options.UseMongoDb(configure);
            });
        }
    }
}
