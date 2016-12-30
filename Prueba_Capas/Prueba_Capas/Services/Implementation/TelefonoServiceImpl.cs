using Prueba_Capas.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prueba_Capas.Models;
using Prueba_Capas.DAOs.Interface;
using Microsoft.Practices.ServiceLocation;

namespace Prueba_Capas.Services.Implementation
{
    public class TelefonoServiceImpl : ITelefonoService
    {
        ITelefonoDAO telefonoDAO = null;

        public TelefonoServiceImpl()
        {
            telefonoDAO = ServiceLocator.Current.GetInstance<ITelefonoDAO>();
        }

        public bool insertarTelefono(Telefono telefono)
        {
            return telefonoDAO.crear(telefono);
        }
    }
}