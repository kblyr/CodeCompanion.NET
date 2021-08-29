using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CodeCompanion
{
    public static class ICodeCompanionServiceCollectionExtensions
    {
        public static ICodeCompanionServiceCollection AddScoped<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this ICodeCompanionServiceCollection instance) where TService : class
        {
            instance.Services.AddScoped<TService>();
            return instance;
        }

        public static ICodeCompanionServiceCollection AddScoped(this ICodeCompanionServiceCollection instance, Type serviceType, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
        {
            instance.Services.AddScoped(serviceType, implementationType);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddScoped(this ICodeCompanionServiceCollection instance, Type serviceType, Func<IServiceProvider, object> implementationFactory)
        {
            instance.Services.AddScoped(serviceType, implementationFactory);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddScoped<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this ICodeCompanionServiceCollection instance)
            where TService : class
            where TImplementation : class, TService
        {
            instance.Services.AddScoped<TService, TImplementation>();
            return instance;
        }

        public static ICodeCompanionServiceCollection AddScoped(this ICodeCompanionServiceCollection instance, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type serviceType)
        {
            instance.Services.AddScoped(serviceType);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddScoped<TService>(this ICodeCompanionServiceCollection instance, Func<IServiceProvider, TService> implementationFactory) where TService : class
        {
            instance.Services.AddScoped(implementationFactory);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddScoped<TService, TImplementation>(this ICodeCompanionServiceCollection instance, Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class
            where TImplementation : class, TService
        {
            instance.Services.AddScoped<TService, TImplementation>(implementationFactory);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddSingleton<TService, TImplementation>(this ICodeCompanionServiceCollection instance, Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class
            where TImplementation : class, TService
        {
            instance.Services.AddSingleton<TService, TImplementation>(implementationFactory);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddSingleton<TService>(this ICodeCompanionServiceCollection instance, Func<IServiceProvider, TService> implementationFactory) where TService : class
        {
            instance.Services.AddSingleton(implementationFactory);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddSingleton<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this ICodeCompanionServiceCollection instance) where TService : class
        {
            instance.Services.AddSingleton<TService>();
            return instance;
        }

        public static ICodeCompanionServiceCollection AddSingleton(this ICodeCompanionServiceCollection instance, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type serviceType)
        {
            instance.Services.AddSingleton(serviceType);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddSingleton<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this ICodeCompanionServiceCollection instance)
            where TService : class
            where TImplementation : class, TService
        {
            instance.Services.AddSingleton<TService, TImplementation>();
            return instance;
        }

        public static ICodeCompanionServiceCollection AddSingleton(this ICodeCompanionServiceCollection instance, Type serviceType, Func<IServiceProvider, object> implementationFactory)
        {
            instance.Services.AddSingleton(serviceType, implementationFactory);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddSingleton(this ICodeCompanionServiceCollection instance, Type serviceType, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
        {
            instance.Services.AddSingleton(serviceType, implementationType);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddSingleton<TService>(this ICodeCompanionServiceCollection instance, TService implementationInstance) where TService : class
        {
            instance.Services.AddSingleton(implementationInstance);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddSingleton(this ICodeCompanionServiceCollection instance, Type serviceType, object implementationInstance)
        {
            instance.Services.AddSingleton(serviceType, implementationInstance);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddTransient<TService, TImplementation>(this ICodeCompanionServiceCollection instance, Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class
            where TImplementation : class, TService
        {
            instance.Services.AddTransient<TService, TImplementation>();
            return instance;
        }

        public static ICodeCompanionServiceCollection AddTransient<TService>(this ICodeCompanionServiceCollection instance, Func<IServiceProvider, TService> implementationFactory) where TService : class
        {
            instance.Services.AddTransient(implementationFactory);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddTransient<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this ICodeCompanionServiceCollection instance) where TService : class
        {
            instance.Services.AddTransient<TService>();
            return instance;
        }

        public static ICodeCompanionServiceCollection AddTransient(this ICodeCompanionServiceCollection instance, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type serviceType)
        {
            instance.Services.AddTransient(serviceType);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddTransient<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this ICodeCompanionServiceCollection instance)
            where TService : class
            where TImplementation : class, TService
        {
            instance.Services.AddTransient<TService, TImplementation>();
            return instance;
        }

        public static ICodeCompanionServiceCollection AddTransient(this ICodeCompanionServiceCollection instance, Type serviceType, Func<IServiceProvider, object> implementationFactory)
        {
            instance.Services.AddTransient(serviceType, implementationFactory);
            return instance;
        }

        public static ICodeCompanionServiceCollection AddTransient(this ICodeCompanionServiceCollection instance, Type serviceType, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
        {
            instance.Services.AddTransient(serviceType, implementationType);
            return instance;
        }

        public static ICodeCompanionServiceCollection Add(this ICodeCompanionServiceCollection instance, ServiceDescriptor descriptor)
        {
            instance.Services.Add(descriptor);
            return instance;
        }

        public static ICodeCompanionServiceCollection Add(this ICodeCompanionServiceCollection instance, IEnumerable<ServiceDescriptor> descriptors)
        {
            instance.Services.Add(descriptors);
            return instance;
        }

        public static ICodeCompanionServiceCollection RemoveAll<T>(this ICodeCompanionServiceCollection instance)
        {
            instance.Services.RemoveAll<T>();
            return instance;
        }

        public static ICodeCompanionServiceCollection RemoveAll(this ICodeCompanionServiceCollection instance, Type serviceType)
        {
            instance.Services.RemoveAll(serviceType);
            return instance;
        }

        public static ICodeCompanionServiceCollection Replace(this ICodeCompanionServiceCollection instance, ServiceDescriptor descriptor)
        {
            instance.Services.Replace(descriptor);
            return instance;
        }

        public static void TryAdd(this ICodeCompanionServiceCollection instance, IEnumerable<ServiceDescriptor> descriptors) => instance.Services.TryAdd(descriptors);

        public static void TryAdd(this ICodeCompanionServiceCollection instance, ServiceDescriptor descriptor) => instance.Services.TryAdd(descriptor);

        public static void TryAddEnumerable(this ICodeCompanionServiceCollection instance, IEnumerable<ServiceDescriptor> descriptors) => instance.Services.TryAddEnumerable(descriptors);

        public static void TryAddEnumerable(this ICodeCompanionServiceCollection instance, ServiceDescriptor descriptor) => instance.Services.TryAddEnumerable(descriptor);

        public static void TryAddScoped<TService>(this ICodeCompanionServiceCollection instance, Func<IServiceProvider, TService> implementationFactory) where TService : class => instance.Services.TryAddScoped(implementationFactory);

        public static void TryAddScoped<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this ICodeCompanionServiceCollection instance)
            where TService : class
            where TImplementation : class, TService => instance.Services.TryAddScoped<TService, TImplementation>();

        public static void TryAddScoped(this ICodeCompanionServiceCollection instance, Type service, Func<IServiceProvider, object> implementationFactory) => instance.Services.TryAddScoped(service, implementationFactory);

        public static void TryAddScoped<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this ICodeCompanionServiceCollection instance) where TService : class => instance.Services.TryAddScoped<TService>();

        public static void TryAddScoped(this ICodeCompanionServiceCollection instance, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type service) => instance.Services.TryAddScoped(service);

        public static void TryAddScoped(this ICodeCompanionServiceCollection instance, Type service, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType) => instance.Services.TryAddScoped(service, implementationType);

        public static void TryAddSingleton(this ICodeCompanionServiceCollection instance, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type service) => instance.Services.TryAddSingleton(service);

        public static void TryAddSingleton(this ICodeCompanionServiceCollection instance, Type service, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType) => instance.Services.TryAddSingleton(service, implementationType);

        public static void TryAddSingleton(this ICodeCompanionServiceCollection instance, Type service, Func<IServiceProvider, object> implementationFactory) => instance.Services.TryAddSingleton(service, implementationFactory);

        public static void TryAddSingleton<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this ICodeCompanionServiceCollection instance) where TService : class => instance.Services.TryAddSingleton<TService>();

        public static void TryAddSingleton<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this ICodeCompanionServiceCollection instance)
            where TService : class
            where TImplementation : class, TService => instance.Services.TryAddSingleton<TService, TImplementation>();

        public static void TryAddSingleton<TService>(this ICodeCompanionServiceCollection instance, TService service) where TService : class => instance.Services.TryAddSingleton<TService>();

        public static void TryAddSingleton<TService>(this ICodeCompanionServiceCollection instance, Func<IServiceProvider, TService> implementationFactory) where TService : class => instance.Services.TryAddSingleton(implementationFactory);

        public static void TryAddTransient<TService>(this ICodeCompanionServiceCollection instance, Func<IServiceProvider, TService> implementationFactory) where TService : class => instance.Services.TryAddTransient(implementationFactory);

        public static void TryAddTransient<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this ICodeCompanionServiceCollection instance)
            where TService : class
            where TImplementation : class, TService => instance.Services.TryAddTransient<TService, TImplementation>();

        public static void TryAddTransient<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this ICodeCompanionServiceCollection instance) where TService : class => instance.Services.TryAddTransient<TService>();

        public static void TryAddTransient(this ICodeCompanionServiceCollection instance, Type service, Func<IServiceProvider, object> implementationFactory) => instance.Services.TryAddTransient(service, implementationFactory);

        public static void TryAddTransient(this ICodeCompanionServiceCollection instance, Type service, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType) => instance.Services.TryAddTransient(service, implementationType);

        public static void TryAddTransient(this ICodeCompanionServiceCollection instance, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type service) => instance.Services.TryAddTransient(service);
    }
}
