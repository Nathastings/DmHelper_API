using System;
using Castle.Core.Configuration;
using Castle.MicroKernel;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;

namespace DMHelper_API.Plumbing
{
    public class WindsorFacility : IFacility
    {
        public void Init(IKernel kernel, IConfiguration facilityConfig)
        {
            kernel.Resolver.AddSubResolver(new CollectionResolver(kernel));
            kernel.Resolver.AddSubResolver(new ArrayResolver(kernel));
            kernel.Resolver.AddSubResolver(new ListResolver(kernel));
        }

        public void Terminate(){}
    }
}