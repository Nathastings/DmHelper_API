using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Castle.Windsor;

namespace DMHelper_API.Plumbing
{
    /// <summary>
    /// A controller factor specific to Windsor which allows me to handle releasing my controller from the IoC container.
    /// </summary>
    public class WindsorControllerFactory : IControllerFactory
    {
        public readonly IWindsorContainer _container;
        /// <summary>
        /// Takes in a windsor container.
        /// </summary>
        /// <param name="container"></param>
        public WindsorControllerFactory(IWindsorContainer container)
        {
            _container = container;
        }

        /// <summary>
        /// Just pass back a controller from the default factory for this section.
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="controllerName"></param>
        /// <returns></returns>
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            return new DefaultControllerFactory().CreateController(requestContext, controllerName);
        }

        /// <summary>
        /// Set session behavior to default.
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="controllerName"></param>
        /// <returns></returns>
        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }
        
        /// <summary>
        /// Take in a controller, dispose of it, and then make sure that it is released from our IoC container.
        /// </summary>
        /// <param name="controller"></param>
        public void ReleaseController(IController controller)
        {
            var disposable = controller as IDisposable;
            if(disposable != null)
            {
                disposable.Dispose();
            }

            _container.Release(controller);
        }
    }
}