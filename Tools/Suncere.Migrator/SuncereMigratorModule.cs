using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Suncere.EntityFramework;

namespace Suncere.Migrator
{
    [DependsOn(typeof(SuncereDataModule))]
    public class SuncereMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SuncereDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}