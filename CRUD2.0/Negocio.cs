using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD2._0
{
    class Negocio
    {
        string objeto;
        public void insertar()
        {
            Console.WriteLine("Digite el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Digite el apellido");
            string apellido = Console.ReadLine();

            Console.WriteLine("Digite el documento de identidad");
            string documentoIdentidad = Console.ReadLine();

            Console.WriteLine("Digite el sexo");
            bool sexo = Console.ReadLine() == "M" ? true : false;

            Console.WriteLine("Digite la fecha de nacimiento");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite la estatura");
            float estatura = float.Parse(Console.ReadLine());

            Persona persona = new Persona();

            persona.nombre = nombre;
            persona.apellido = apellido;
            persona.documentoIdentidad = documentoIdentidad;
            persona.sexo = sexo;
            persona.fechaNacimiento = fechaNacimiento;
            persona.estatura = estatura;
            persona.fechaRegistro = DateTime.Now;
            persona.fechaModificacion = DateTime.Now;


            //APLICO POLIMORFISMO
            IAccesoDatos iAccesoDatos = new AccesoDatos();

            if (iAccesoDatos.create(persona)){
                Console.WriteLine("Los registros se han insertado correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrio un error");

            }


        



        }

        public void listar()
        {

        }
        public void editar()
        {

        }

        public void eliminar()
        {

        }
    }
}
