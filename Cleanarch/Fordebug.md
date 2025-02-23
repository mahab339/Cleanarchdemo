System.AggregateException
  HResult=0x80131500
  Message=Some services are not able to be constructed (Error while validating the service descriptor 'ServiceType: 
  Cleanarch.Domain.Core.Bus.Imediatorhandler 
  Lifetime: Scoped ImplementationType: 
  Cleanarch.Infra.Bus.Inmemorybus': 
  Unable to resolve service for type 'MediatR.IMediator' while attempting to activate 'Cleanarch.Infra.Bus.Inmemorybus'.) 
  (Error while validating the service descriptor 'ServiceType: Cleanarch.Application.Interfaces.Icourseservice
  Lifetime: Scoped ImplementationType: 
  Cleanarch.Application.Services.Course': 
  Unable to resolve service for type 'MediatR.IMediator' while attempting to activate 'Cleanarch.Infra.Bus.Inmemorybus'.)
  Source=Microsoft.Extensions.DependencyInjection
  StackTrace:
   at Microsoft.Extensions.DependencyInjection.ServiceProvider..ctor(ICollection`1 serviceDescriptors, ServiceProviderOptions options)
   at Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(IServiceCollection services, ServiceProviderOptions options)
   at Microsoft.Extensions.Hosting.HostApplicationBuilder.Build()
   at Microsoft.AspNetCore.Builder.WebApplicationBuilder.Build()
   at Cleanarch.Mvc.Program.Main(String[] args) in C:\Users\asus\Documents\Cleanarchdemo\Cleanarch\Cleanarch.Mvc\Program.cs:line 31

  This exception was originally thrown at this call stack:
    Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory.CreateArgumentCallSites(Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier, System.Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteChain, System.Reflection.ParameterInfo[], bool)
    Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory.CreateConstructorCallSite(Microsoft.Extensions.DependencyInjection.ServiceLookup.ResultCache, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier, System.Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteChain)
    Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory.TryCreateExact(Microsoft.Extensions.DependencyInjection.ServiceDescriptor, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier, Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteChain, int)
    Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory.GetCallSite(Microsoft.Extensions.DependencyInjection.ServiceDescriptor, Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteChain)
    Microsoft.Extensions.DependencyInjection.ServiceProvider.ValidateService(Microsoft.Extensions.DependencyInjection.ServiceDescriptor)

Inner Exception 1:
InvalidOperationException: Error while validating the service descriptor 'ServiceType: Cleanarch.Domain.Core.Bus.Imediatorhandler Lifetime: Scoped ImplementationType: Cleanarch.Infra.Bus.Inmemorybus': Unable to resolve service for type 'MediatR.IMediator' while attempting to activate 'Cleanarch.Infra.Bus.Inmemorybus'.

Inner Exception 2:
InvalidOperationException: Unable to resolve service for type 'MediatR.IMediator' while attempting to activate 'Cleanarch.Infra.Bus.Inmemorybus'.
