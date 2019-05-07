using System;
using System.Collections.Generic;
using System.Text;

namespace Example.IoC.Shell.Abstractions
{
    public class ServiceLocator
    {
        private readonly Dictionary<Type, Object> instances = new Dictionary<Type, Object>();

        public void Add(Type type, Object instance)
        {
            instances.Add(type, instance);
        }

        public void Add<T>(Object instance)
        {
            instances.Add(typeof(T), instance);
        }

        public Object Get(Type type)
        {
            return instances[type];
        }

        public T Get<T>()
        {
            return (T)instances[typeof(T)];
        }

        public void Reset()
        {
            instances.Clear();
        }

        public static ServiceLocator Singleton = new ServiceLocator();
    }
}
