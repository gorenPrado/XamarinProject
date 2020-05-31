using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinCalendarProject.Repositorio;
using XamarinCalendarProject.ViewModels;

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
            builder.RegisterType<CalendarioViewModel>();

            container = builder.Build();
        }
        public CalendarioViewModel CalendarioViewModel
        {
            get
            {
                return container.Resolve<CalendarioViewModel>();
            }
        }

    }
}
