using System;

namespace CRUD2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionSeleccionada = 0;
            int x;

            //OBJETO NEGOCIO
            Negocio negocio = new Negocio();

            while(opcionSeleccionada != 5)
            {
                Console.WriteLine("**** BIENVENIDO AL SISTEMA *****");
                Console.WriteLine("1. Insertar datos");
                Console.WriteLine("2. Listar datos");
                Console.WriteLine("3. Editar los datos");
                Console.WriteLine("4. Eliminar los datos");
                Console.WriteLine("------------------------");

                Console.WriteLine("Ingrese una opcion");

                string opcionSeleccionaTemporal = Console.ReadLine();

                if(int.TryParse(opcionSeleccionaTemporal,out x))
                {
                    opcionSeleccionada = int.Parse(opcionSeleccionaTemporal);

                    switch (opcionSeleccionada)
                    {
                        case 1:
                            negocio.insertar();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;

                        default:
                            Console.WriteLine("La opcion seleccionada es invalida");
                            break;






                    }

                }
                else
                {
                    opcionSeleccionada = 0;
                    Console.WriteLine("El valor ingresado no es correcto");
                }

                if(opcionSeleccionada != 5)
                {
                    Console.ReadLine();
                }
                Console.Clear();
            }
        }
    }
}
