using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Palembang.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="StaticValueProjectNameProvider"/> implementation of <see cref="IProjectNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValueProjectNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProjectNameProvider, StaticValueProjectNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValueProjectNameProvider"/> implementation of <see cref="IProjectNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValueProjectNameProvider<TProjectNameProvider>(this IServiceCollection services)
            where TProjectNameProvider: IProjectNameProvider
        {
            services.AddStaticValueProjectNameProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValueProjectNameProvider"/> implementation of <see cref="IProjectNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IProjectNameProvider> AddStaticValueProjectNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IProjectNameProvider>(() => services.AddStaticValueProjectNameProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="StaticValueSolutionNameProvider"/> implementation of <see cref="ISolutionNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValueSolutionNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<ISolutionNameProvider, StaticValueSolutionNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValueSolutionNameProvider"/> implementation of <see cref="ISolutionNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValueSolutionNameProvider<TSolutionNameProvider>(this IServiceCollection services)
            where TSolutionNameProvider : ISolutionNameProvider
        {
            services.AddStaticValueSolutionNameProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValueSolutionNameProvider"/> implementation of <see cref="ISolutionNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ISolutionNameProvider> AddStaticValueSolutionNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ISolutionNameProvider>(() => services.AddStaticValueSolutionNameProvider());
            return serviceAction;
        }
    }
}
