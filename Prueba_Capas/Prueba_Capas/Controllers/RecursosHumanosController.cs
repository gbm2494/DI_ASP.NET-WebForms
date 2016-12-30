using Prueba_Capas.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.ServiceLocation;
using Prueba_Capas.Models;

namespace Prueba_Capas.Controllers
{
    class RecursosHumanosController
    {
        IPersonaService personaService = null;

        public RecursosHumanosController() {
            personaService = ServiceLocator.Current.GetInstance<IPersonaService>();
        }

        public Boolean insertarRecursoHumano(String cedula, String nombre, String apellido1, String apellido2, List<String> telefonos) {

            ICollection<Telefono> tels = new List<Telefono>();

            Persona objeto = new Persona();
            objeto.nombre = nombre;
            objeto.cedula = cedula;
            objeto.apellido1 = apellido1;
            objeto.apellido2 = apellido2;

            foreach (String temp in telefonos) {
                if (temp != "")
                {
                    Telefono nuevo = new Telefono();
                    nuevo.numero = temp;
                    nuevo.cedulaP = cedula;
                    tels.Add(nuevo);
                }  
            }

            objeto.Telefono = tels;

            return personaService.insertarPersona(objeto);
        }
    }
}
