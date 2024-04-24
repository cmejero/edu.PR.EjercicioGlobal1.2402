using edu.PR.EjercicioGlobal1._2404.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.EjercicioGlobal1._2404.Servicios
{
    internal interface OperacionInterfaz
    {
        public void darAltaLibro(List<LibroDto> listaAntiguaLibros);
        public void darAltaBiblioteca(List<BibliotecaDto> listaAntiguaBiblioteca);
        public void darAltaCliente(List<ClienteDto> listaAntiguaCLiente);
        public void darAltaPrestamo(List<PrestamoDto> listaAntiguaPrestamo);
    }
}

