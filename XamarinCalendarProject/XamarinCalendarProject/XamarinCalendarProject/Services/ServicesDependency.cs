using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinCalendarProject.Repositorio;

namespace XamarinCalendarProject.Services
{
    public class ServiceDependency
    {

        private IContainer container;

        public ServiceDependency()
        {
            RegisterDependencies();
        }

        private void RegisterDependencies()
        {
            ContainerBuilder builder = new ContainerBuilder();
            
            builder.RegisterType<RepositorioCalendario>();

            container = builder.Build();
        }

    }
}
