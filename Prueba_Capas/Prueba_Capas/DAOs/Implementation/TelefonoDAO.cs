using Prueba_Capas.DAOs.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prueba_Capas.Models;

namespace Prueba_Capas.DAOs.Implementation
{
    public class TelefonoDAO : ITelefonoDAO
    {
        private Entities baseDatos = new Entities();

        public bool crear(Telefono telefono)
        {
            bool resultado = false;
            try
            {
                baseDatos.Telefono.Add(telefono);
                baseDatos.SaveChanges();
                resultado = true;
            }
            catch (Exception e)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}