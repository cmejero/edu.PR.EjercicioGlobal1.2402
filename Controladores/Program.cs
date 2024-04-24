using edu.PR.EjercicioGlobal1._2404.Dtos;
using edu.PR.EjercicioGlobal1._2404.Servicios;
using edu.PR.EjercicioGlobal1._2404.Dtos;
using edu.PR.EjercicioGlobal1._2404.Servicios;
using System.ComponentModel.Design;

namespace edu.PR.EjercicioGlobal1._2404.Controladores
{
    internal class Program
    {
        static public List<LibroDto> listaLibros = new List<LibroDto>();
        static public List<BibliotecaDto> listaBiblioteca = new List<BibliotecaDto>();
        static public List<ClienteDto> listaCliente = new List<ClienteDto>();
        static public List<PrestamoDto> listaPrestamo = new List<PrestamoDto>();

        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();

            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                opcionUsuario = mi.menuYSeleccion();

                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine(" Has indicado cerrar aplicacion");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Has Seleccionado dar alta a una nueva biblioteca");
                        oi.darAltaBiblioteca(listaBiblioteca);
                        break;

                    case 2:
                        Console.WriteLine("Has Seleccionado acceder a una biblioteca");
                        mi.accederBiblioteca();
                        break;

                    default:
                        Console.WriteLine("La opcion seleccionada no corresponde con niguna");
                        break;
                }
            } while (!cerrarMenu);
        }
    }
}

