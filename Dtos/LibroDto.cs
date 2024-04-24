using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.EjercicioGlobal1._2404.Dtos
{
    internal class LibroDto
    {
        long idLibro;
        string titulo = "aaaaa";
        string subtitulo = "aaaaa";
        string autor = "aaaaa";
        string ISBN = "aaaaa";
        int numEdicion = 0;
        string editorial = "aaaaa";
        int stock = 0;

        public LibroDto()
        {
        }

        public LibroDto(long idLibro, string titulo, string subtitulo, string autor, string iSBN, int numEdicion, string editorial, int stock)
        {
            this.idLibro = idLibro;
            this.titulo = titulo;
            this.subtitulo = subtitulo;
            this.autor = autor;
            ISBN = iSBN;
            this.numEdicion = numEdicion;
            this.editorial = editorial;
            this.stock = stock;
        }

        public long IdLibro { get => idLibro; set => idLibro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Subtitulo { get => subtitulo; set => subtitulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public int NumEdicion { get => numEdicion; set => numEdicion = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
