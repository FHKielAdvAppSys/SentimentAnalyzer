using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalyzer.Core
{
    public class DIManager : IDisposable
    {
        private WindsorContainer _container;

        public static readonly DIManager Instance = new DIManager();

        private DIManager() 
        {
            _container = new WindsorContainer();
        }

        public void Register<TContract, TService>(LifeCycle lifecycle)
            where TContract : class
            where TService: TContract
        {
            var component = Component.For<TContract>().ImplementedBy<TService>();

            switch (lifecycle)
            {
                case LifeCycle.Transient:
                    component = component.LifestyleTransient();
                    break;
                case LifeCycle.Singletone:
                    component = component.LifestyleSingleton();
                    break;
                case LifeCycle.PerThread:
                    component = component.LifestylePerThread();
                    break;
                default:
                    throw new NotSupportedException("Lifecycle");
            }

            _container.Register(component);
        }

        public TService Resolve<TService>()
        {
            return _container.Resolve<TService>();
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }

    public enum LifeCycle
    {
        Transient, Singletone, PerThread
    }
}
