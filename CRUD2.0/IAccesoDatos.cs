using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD2._0
{
    interface IAccesoDatos
    {
        bool create(Persona persona);
        List<Persona> read();
        bool update(Persona persona);
        bool delete(string documentoIdentidad);
    }
}
