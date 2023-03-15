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

            if (iAccesoDatos.create(persona))
            {
                Console.WriteLine("Los registros se han insertado correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrio un error");

            }

        }

        public void listar()
        {
            IAccesoDatos iAccesoDatos = new AccesoDatos();

            List<Persona> listaPersona = iAccesoDatos.read();

            int i = 1;

            foreach(Persona item in listaPersona)
            {
                Console.WriteLine(i + "Nombre: " + item.nombre + "\n"
                                    + "Apellido: " + item.apellido + "\n"
                                    + "Documento de identidad " + item.documentoIdentidad + "\n"
                                    + "Fecha de nacimiento " + item.fechaNacimiento + "\n"
                                    + "Estatura " + item.estatura + "\n"
                                    + "Fecha de Modificacion " + item.fechaModificacion + "\n"
                                    + "Fecha de Registro " + item.fechaRegistro);

                i++;
            }

        }
        public void editar()
        {
            listar();

            Console.WriteLine("");

            Console.WriteLine("Digite la posicion de la persona que quiere editar");
            int posicionPersona = int.Parse(Console.ReadLine());



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
           // persona.fechaRegistro = DateTime.Now;
            persona.fechaModificacion = DateTime.Now;


            //APLICO POLIMORFISMO
            IAccesoDatos iAccesoDatos = new AccesoDatos();

            if (iAccesoDatos.update(persona, posicionPersona))
            {
                Console.WriteLine("Los registros se han modificado correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrio un error en la modificacion");

            }




        }

        public void eliminar()
        {
            listar();

            Console.WriteLine("");
            Console.WriteLine("Ingrese el documento unico de identidad");
            String documentoIdentidad = Console.ReadLine();

            IAccesoDatos iAccesoDatos = new AccesoDatos();

            if (iAccesoDatos.delete(documentoIdentidad))
            {
                Console.WriteLine("Persona eliminada correctamente");
            }
            else
            {
                Console.WriteLine("No se ha podido eliminar, no existe ese registro");
            }

        }
    }
}
