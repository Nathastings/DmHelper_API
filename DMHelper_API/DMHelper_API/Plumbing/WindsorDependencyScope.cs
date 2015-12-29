using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using Castle.MicroKernel;
using Castle.MicroKernel.Lifestyle;

namespace DMHelper_API.Plumbing
{
    public class WindsorDependencyScope : IDependencyScope
    {
        private readonly IKernel _kernel;
        private readonly IDisposable _scope;
        private bool _disposed;

        public WindsorDependencyScope(IKernel kernel)
        {
            _kernel = kernel;
            _scope = kernel.BeginScope();
        }
        
        public object GetService(Type serviceType)
        {
            return _kernel.HasComponent(serviceType) ? _kernel.Resolve(serviceType) : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.ResolveAll(serviceType).Cast<object>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
                _scope.Dispose();

            _disposed = true;
        }
    }
}