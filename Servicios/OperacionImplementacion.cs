using edu.PR.EjercicioGlobal1._2404.Controladores;
using edu.PR.EjercicioGlobal1._2404.Dtos;
using edu.PR.EjercicioGlobal1._2404.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.EjercicioGlobal1._2404.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {


        public void darAltaLibro(List<LibroDto> listaAntiguaLibros)
        {
            LibroDto nuevoLibro = new LibroDto();

            long idLibro = autoincrementarID(listaAntiguaLibros);
            Console.WriteLine("introduzca titulo de libro");
            nuevoLibro.Titulo = Console.ReadLine();
            Console.WriteLine("introduzca  subtitulo libro");
            nuevoLibro.Subtitulo = Console.ReadLine();
            Console.WriteLine("introduzca el autor");
            nuevoLibro.Autor = Console.ReadLine();
            Console.WriteLine("introduzca ISBN");
            nuevoLibro.ISBN1 = Console.ReadLine();
            Console.WriteLine("introduzca el nuemero de la edición");
            nuevoLibro.NumEdicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca el nombre el editorial");
            nuevoLibro.Editorial = Console.ReadLine();
            Console.WriteLine("introduzca el stock");
            nuevoLibro.Stock = Convert.ToInt32(Console.ReadLine());

            listaAntiguaLibros.Add(nuevoLibro);

        }

        private long autoincrementarID(List<LibroDto> listaLibro)
        {
            long nuevoId;
            int tamanioLista = listaLibro.Count;
            if (tamanioLista > 0)
            {
                nuevoId = listaLibro[tamanioLista - 1].IdLibro + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;

        }


        public void darAltaBiblioteca(List<BibliotecaDto> listaAntiguaBiblioteca)
        {
            BibliotecaDto nuevaBiblioteca = new BibliotecaDto();

            long idBliblioteca = autoincrementarID(listaAntiguaBiblioteca);
            Console.WriteLine("introduzca nombre bliblioteca");
            nuevaBiblioteca.Nombre = Console.ReadLine();
            Console.WriteLine("introduzca  direccion");
            nuevaBiblioteca.Direccion = Console.ReadLine();


            listaAntiguaBiblioteca.Add(nuevaBiblioteca);

        }

        private long autoincrementarID(List<BibliotecaDto> listaBiblioteca)
        {
            long nuevoId;
            int tamanioLista = listaBiblioteca.Count;
            if (tamanioLista > 0)
            {
                nuevoId = listaBiblioteca[tamanioLista - 1].IdBiblioteca + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;

        }


        public void darAltaCliente(List<ClienteDto> listaAntiguaCLiente)
        {
            Console.WriteLine("introduzca DNI");
            string DNI = Console.ReadLine();

            foreach (ClienteDto cliente in listaAntiguaCLiente)
            {
                if (cliente.DniCLiente.Equals(DNI))
                {

                    cliente.IdCliente = autoincrementarID(listaAntiguaCLiente);
                    Console.WriteLine("introduzca nombre cliente");
                    cliente.NombreCliente = Console.ReadLine();
                    Console.WriteLine("introduzca  apellidos");
                    cliente.ApellidosCliente = Console.ReadLine();
                    Console.WriteLine("introduzca fecha de nacimiento");
                    string fechaNac = Console.ReadLine();
                    cliente.DniCLiente = DNI;
                    Console.WriteLine("introduzca correo electronico");
                    cliente.CorreoCliente = Console.ReadLine();

                    cliente.FechaNaciminetoCliente = Convert.ToDateTime(fechaNac);

                    listaAntiguaCLiente.Add(cliente);

                }
                else
                {
                    Console.WriteLine("El DNI introducido ya existe");
                }
            }



        }

        private long autoincrementarID(List<ClienteDto> listaCliente)
        {

            long nuevoId;
            int tamanioLista = listaCliente.Count;
            if (tamanioLista > 0)
            {
                nuevoId = listaCliente[tamanioLista - 1].IdCliente + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;

        }

        public void darAltaPrestamo(List<PrestamoDto> listaAntiguaPrestamo)
        {
            Console.WriteLine("Introduzca el DNI del cliente al cual se va a realizar el prestamo");
            string DNIClienteIntroducido = Console.ReadLine();

            Console.WriteLine("Introduzca el Titulo del libro");
            string libroElegido = Console.ReadLine();

            foreach (ClienteDto clientes in Program.listaCliente)
            {
                if (clientes.DniCLiente.Equals(DNIClienteIntroducido))
                {
                    foreach (LibroDto libros in Program.listaLibros)
                    {
                        if (libros.Titulo.Equals(libroElegido))
                        {
                            if (libros.Stock > 0)
                            {
                                long idIntroducido = Convert.ToInt64(Console.ReadLine());
                                PrestamoDto prestamo = new PrestamoDto();

                                long idPrestamo = autoincrementarID(listaAntiguaPrestamo);
                                prestamo.IdCliente = clientes.IdCliente;
                                Console.WriteLine("introduzca el id del libro");
                                prestamo.IdLibro = libros.IdLibro;
                                Console.WriteLine("introduzca fecha prestamo");
                                string fechaPrestamo = Console.ReadLine();
                                Console.WriteLine("introduzca fecha entrega");
                                string fechaEntrega = Console.ReadLine();
                                Console.WriteLine("introduzca estado del prestamo");
                                prestamo.EstadoPrestamo = Console.ReadLine();

                                prestamo.FechaPrestamo = Convert.ToDateTime(fechaPrestamo);
                                prestamo.FechaEntrega = Convert.ToDateTime(fechaEntrega);

                                listaAntiguaPrestamo.Add(prestamo);
                            }
                            else
                            {
                                Console.WriteLine("No tenemos stock de este libro");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El libro introducido no existe");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El cliente introducido no existe, dar de alta");
                }
            }



        }

        private long autoincrementarID(List<PrestamoDto> listaPrestamo)
        {
            long nuevoId;
            int tamanioLista = listaPrestamo.Count;
            if (tamanioLista > 0)
            {
                nuevoId = listaPrestamo[tamanioLista - 1].IdPrestamo + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;

        }


    }
}