using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD2._0
{
    class Persona:Auditoria
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string documentoIdentidad { get; set; }
        public bool sexo { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public float estatura { get; set; }

    }
}
