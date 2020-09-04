using Autofac;
using ProjectDDD.Application;
using ProjectDDD.Application.Interfaces;
using ProjectDDD.Application.Mappers;
using ProjectDDD.Application.Mappers.Interfaces;
using ProjectDDD.Domain.Core.Interfaces.Repositorys;
using ProjectDDD.Domain.Core.Interfaces.Services;
using ProjectDDD.Domain.Services;
using ProjectDDD.Infra.Data.Repositorys;

namespace ProjectDDD.Infra.CrossCutting.IOC
{
    public class ConfigurationIoc
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Cliente
            builder.RegisterType<ClienteApplicationService>().As<IClienteApplicationService>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<ClienteMapper>().As<IClienteMapper>();
            #endregion

            #region Estoque
            builder.RegisterType<EstoqueApplicationService>().As<IEstoqueApplicationService>();
            builder.RegisterType<EstoqueService>().As<IEstoqueService>();
            builder.RegisterType<EstoqueRepository>().As<IEstoqueRepository>();
            builder.RegisterType<EstoqueMapper>().As<IEstoqueMapper>();
            #endregion
        }
    }
}
