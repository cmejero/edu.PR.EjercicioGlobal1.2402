using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.EjercicioGlobal1._2404.Dtos
{
    internal class BibliotecaDto
    {

        long idBiblioteca;
        string nombre = "aaaaa";
        string direccion = "aaaaa";

        public BibliotecaDto()
        {
        }

        public BibliotecaDto(long idBiblioteca, string nombre, string direccion)
        {
            this.idBiblioteca = idBiblioteca;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }


    }
}
