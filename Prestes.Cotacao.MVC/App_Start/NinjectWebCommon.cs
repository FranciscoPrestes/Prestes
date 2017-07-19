using Prestes.Cotacao.Infra.Data.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Prestes.Cotacao.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Prestes.Cotacao.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace Prestes.Cotacao.MVC.App_Start
{
    using System;
    using System.Web;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Prestes.Cotacao.Application.Interfaces;
    using Prestes.Cotacao.Application.Services;
    using Prestes.Cotacao.Domain.Interfaces.Services;
    using Prestes.Cotacao.Domain.Interfaces.Repository;
    using Prestes.Cotacao.Domain.Services;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {

            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<ICompreadorAppService>().To<CompradorAppService>();
            kernel.Bind<IFornecedorAppService>().To<FornecedorAppService>();
            kernel.Bind<IEmpresaAppService>().To<EmpresaAppService>();
           

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<ICompradorService>().To<CompradorService>();
            kernel.Bind<IFornecedorService>().To<FornecedorService>();
            kernel.Bind<IEmpresaService>().To<EmpresaService>();
            
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<ICompradorRepository>().To<CompradorRepository>();
            kernel.Bind<IFornecedorRepository>().To<FornecedorRepository>();
            kernel.Bind<IEmpresaRepository>().To<EmpresaRepository>();

        }
    }
}
