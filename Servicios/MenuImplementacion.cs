using edu.PR.EjercicioGlobal1._2404.Controladores;
using edu.PR.EjercicioGlobal1._2404.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.EjercicioGlobal1._2404.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        OperacionInterfaz oi = new OperacionImplementacion();

        public int menuYSeleccion()
        {
            int opcionUsuario;
            Console.WriteLine("############################");
            Console.WriteLine("0. Cerrar Aplicación");
            Console.WriteLine("1. Dar alta nueva Biblioteca");
            Console.WriteLine("2. acceder a una biblioteca");
            Console.WriteLine("############################");
            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }

        private int menuYSeleccionBiblioteca()
        {
            int opcionUsuario;
            Console.WriteLine("############################");
            Console.WriteLine("0. Retroceder");
            Console.WriteLine("1. Dar alta nuevo cliente");
            Console.WriteLine("2. Dar alta nuevo libro");
            Console.WriteLine("3. Dar alta nuevo prestamo");
            Console.WriteLine("############################");
            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
        }

        public void accederBiblioteca()
        {
            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                opcionUsuario = menuYSeleccionBiblioteca();

                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Has seleccionado retroceder");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Has seleccionado dar alta nuevo cliente");
                        oi.darAltaCliente(Program.listaCliente);
                        break;

                    case 2:
                        Console.WriteLine("Has seleccionado dar alta nuevo libro");
                        oi.darAltaLibro(Program.listaLibros);
                        break;

                    case 3:
                        Console.WriteLine("Has seleccionado dar alta nuevo prestamo");
                        oi.darAltaPrestamo(Program.listaPrestamo);
                        break;

                    default:
                        Console.WriteLine("la opcion seleccionada no corresponde con niguna");
                        break;


                }
            } while (!cerrarMenu);
        }
    }
}