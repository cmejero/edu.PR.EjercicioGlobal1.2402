using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.EjercicioGlobal1._2404.Dtos
{
    internal class PrestamoDto
    {
        long idPrestamo;
        long idCliente;
        long idLibro;
        DateTime fechaPrestamo;
        DateTime fechaEntrega;
        string estadoPrestamo;

        public PrestamoDto(long idPrestamo, long idCliente, long idLibro, DateTime fechaPrestamo, DateTime fechaEntrega, string estadoPrestamo)
        {
            this.idPrestamo = idPrestamo;
            this.idCliente = idCliente;
            this.idLibro = idLibro;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaEntrega = fechaEntrega;
            this.estadoPrestamo = estadoPrestamo;
        }

        public long IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public long IdLibro { get => idLibro; set => idLibro = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }

        public PrestamoDto()
        {

        }
    }
}
