using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.ServiceLocation;
using Prueba_Capas.Services.Interface;
using Prueba_Capas.Services.Implementation;
using Prueba_Capas.DAOs.Interface;
using Prueba_Capas.DAOs.Implementation;

namespace Prueba_Capas
{
    public static class Bootstrapper
    {
        private static readonly IUnityContainer container = new UnityContainer();

        public static void Initialize() {
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));

            container.RegisterType<IPersonaService, PersonaServiceImpl>();
            container.RegisterType<ITelefonoService, TelefonoServiceImpl>();
            container.RegisterType<IPersonaDAO, PersonaDAO>();
            container.RegisterType<ITelefonoDAO, TelefonoDAO>();
        }

        public static void TearDown() {
            container.Dispose();
        }
    }
}
