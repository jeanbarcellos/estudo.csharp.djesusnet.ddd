using Autofac;
using AutoMapper;
using WebApi.Application.Interfaces;
using WebApi.Application.Mappers;
using WebApi.Application.Services;
using WebApi.Domain.Core.Interfaces.Repositories;
using WebApi.Domain.Core.Interfaces.Services;
using WebApi.Domain.Services.Services;
using WebApi.Infrastructure.Data;

namespace WebApi.Infrastructure.CrossCutting.IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IoC

            // Infrastructure.Data
            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();

            // Domain
            builder.RegisterType<ClientService>().As<IClientService>();
            builder.RegisterType<ProductService>().As<IProductService>();

            // Application
            builder.RegisterType<ClientApplicationService>().As<IClientApplicationService>();
            builder.RegisterType<ProductApplicationService>().As<IProductApplicationService>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ClientDTOToEntityMapping());
                cfg.AddProfile(new ClientEntityToDTOMapping());
                cfg.AddProfile(new ProductDTOToEntityMapping());
                cfg.AddProfile(new ProductEntityToDTOMapping());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            #endregion IoC
        }
    }
}
