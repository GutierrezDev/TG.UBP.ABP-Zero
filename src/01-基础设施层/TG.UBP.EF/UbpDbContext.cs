﻿using System.Data.Common;
using System.Linq;
using Abp.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TG.UBP.EF
{
    public class UbpDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public DbSet<TG.UBP.Domain.Entity.Module> Modules { get; set; }
        public DbSet<TG.UBP.Domain.Entity.User> Users { get; set; }

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public UbpDbContext()
            : base("Default")
        {
            Database.Log = log => System.Diagnostics.Debug.WriteLine(log);
        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in UBPDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of UBPDbContext since ABP automatically handles it.
         */
        public UbpDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Database.Log = log => System.Diagnostics.Debug.WriteLine(log);
        }

        //This constructor is used in tests
        public UbpDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public UbpDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        /// <summary>
        /// 在完成对派生上下文的模型的初始化后，并在该模型已锁定并用于初始化上下文之前，将调用此方法。虽然此方法的默认实现不执行任何操作，但可在派生类中重写此方法，这样便能在锁定模型之前对其进行进一步的配置。
        /// </summary>
        /// <param name="modelBuilder">定义要创建的上下文的模型的生成器。</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //移除一对多的级联删除
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //注册实体配置信息
            IEntityMapper[] entityMappers = DbContextManager.Instance.GetEntityMappers().ToArray();
            foreach (IEntityMapper mapper in entityMappers)
            {
                mapper.RegistTo(modelBuilder.Configurations);
            }
        }
    }
}
