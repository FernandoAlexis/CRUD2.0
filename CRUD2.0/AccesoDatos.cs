using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD2._0
{
    class AccesoDatos : IAccesoDatos
    {
        public bool create(Persona persona)
        {
            Datos.dataPersona.Add(persona);

            return true;
        }

        public bool delete(string documentoIdentidad)
        {
            throw new NotImplementedException();
        }

        public List<Persona> read()
        {
            throw new NotImplementedException();
        }

        public bool update(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
