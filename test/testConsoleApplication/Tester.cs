using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TG.UBP.Domain.Entity;

namespace TestConsoleApplication
{
    public class Tester : ITransientDependency
    {
        public ILogger Logger { get; set; }

        private readonly IRepository<Module, int> _moduleRepository;
        private readonly IRepository<User, int> _userRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public Tester(IRepository<Module, int> moduleRepository
            , IRepository<User, int> userRepository
            , IUnitOfWorkManager unitOfWorkManager)
        {
            _moduleRepository = moduleRepository;
            _userRepository = userRepository;
            _unitOfWorkManager = unitOfWorkManager;

            Logger = NullLogger.Instance;
        }

        public void Run()
        {
            //InintDevartOracle();
            Logger.Debug("Started Tester.Run()");

            var module = _moduleRepository.Insert(new Module() { EnCode = "test11", FullName = "test11" });
            //_moduleRepository.Insert(new Module() { EnCode = "test2", FullName = "test2" });
            //_moduleRepository.Insert(new Module() { EnCode = "test3", FullName = "test3" });
            //_moduleRepository.Insert(new Module() { EnCode = "test4", FullName = "test4" });

            //_userRepository.Insert(new User() { EnCode = "test1", FullName = "test1" });
            //_userRepository.Insert(new User() { EnCode = "test1", FullName = "test1" });

            Console.WriteLine("禁用过滤器");
            using (var unitOfWork = _unitOfWorkManager.Begin())
            {
                //Devart.Data.Oracle.OracleMonitor monitor = new Devart.Data.Oracle.OracleMonitor() { IsActive = true };
                _unitOfWorkManager.Current.DisableFilter(AbpDataFilters.SoftDelete);
                //GetAllList
                foreach (var user in _moduleRepository.GetAllList())
                {
                    Console.WriteLine(user);
                }
            }


            //Console.WriteLine("启用过滤器");
            //using (var unitOfWork = _unitOfWorkManager.Begin())
            //{
            //    //Devart.Data.Oracle.OracleMonitor monitor = new Devart.Data.Oracle.OracleMonitor() { IsActive = true };
            //    _unitOfWorkManager.Current.EnableFilter(AbpDataFilters.SoftDelete);
            //    //GetAllList
            //    foreach (var user in _moduleRepository.GetAllList())
            //    {
            //        Console.WriteLine(user);
            //    }
            //}

            Logger.Debug("Finished Tester.Run()");
        }

        private void InintDevartOracle()
        {
            Devart.Data.Oracle.OracleMonitor monitor = new Devart.Data.Oracle.OracleMonitor() { IsActive = true };
            Devart.Data.Oracle.Entity.Configuration.OracleEntityProviderConfig devartConfig = Devart.Data.Oracle.Entity.Configuration.OracleEntityProviderConfig.Instance;
            devartConfig.Workarounds.IgnoreSchemaName = true;
            devartConfig.Workarounds.DisableQuoting = true;
            devartConfig.CodeFirstOptions.UseDateTimeAsDate = true;
            devartConfig.CodeFirstOptions.UseNonLobStrings = true;
            devartConfig.CodeFirstOptions.UseNonUnicodeStrings = true;
            devartConfig.CodeFirstOptions.TruncateLongDefaultNames = true;
            //devartConfig.DatabaseScript.Column.MaxStringSize = Devart.Data.Oracle.Entity.Configuration.OracleMaxStringSize.Standard;
        }
    }
}
