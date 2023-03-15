using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD2._0
{
    abstract class Auditoria
    {
        public DateTime fechaRegistro { get; set; }
        public DateTime fechaModificacion { get; set; }
    }
}
