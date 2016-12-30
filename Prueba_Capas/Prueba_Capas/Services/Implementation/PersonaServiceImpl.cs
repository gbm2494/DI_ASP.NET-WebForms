using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prueba_Capas.Services.Interface;
using Prueba_Capas.Models;
using Prueba_Capas.DAOs.Interface;
using Microsoft.Practices.ServiceLocation;

namespace Prueba_Capas.Services.Implementation
{
    public class PersonaServiceImpl : IPersonaService
    {
        IPersonaDAO personaDAO = null;
        ITelefonoService telefonoService = null;

        public PersonaServiceImpl() {
            personaDAO = ServiceLocator.Current.GetInstance<IPersonaDAO>();
            telefonoService = ServiceLocator.Current.GetInstance<ITelefonoService>();
        }

        public Boolean insertarPersona(Persona persona)
        {
            ICollection<Telefono> tels = persona.Telefono;
            persona.Telefono = null;
            Boolean resultado = false;

            if (personaDAO.crear(persona))
            {
                foreach (Telefono tel in tels){
                    resultado = telefonoService.insertarTelefono(tel);
                }
            }

            return resultado;
        }
    }
}