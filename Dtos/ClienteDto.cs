using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.EjercicioGlobal1._2404.Dtos
{
    internal class ClienteDto
    {
        long idCliente;
        string nombreCliente = "aaaa";
        string apellidosCliente = "aaaaa";
        DateTime fechaNaciminetoCliente;
        string dniCLiente = "aaaaa";
        string correoCliente = "aaaaa";
        DateTime fechaInicioSuspensionCliente;
        DateTime fechaFinSuspensionCliente;

        public ClienteDto()
        {
        }

        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, DateTime fechaNaciminetoCliente, string dniCLiente, string correoCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.fechaNaciminetoCliente = fechaNaciminetoCliente;
            this.dniCLiente = dniCLiente;
            this.correoCliente = correoCliente;
            this.fechaInicioSuspensionCliente = fechaInicioSuspensionCliente;
            this.fechaFinSuspensionCliente = fechaFinSuspensionCliente;
        }

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public DateTime FechaNaciminetoCliente { get => fechaNaciminetoCliente; set => fechaNaciminetoCliente = value; }
        public string DniCLiente { get => dniCLiente; set => dniCLiente = value; }
        public string CorreoCliente { get => correoCliente; set => correoCliente = value; }
        public DateTime FechaInicioSuspensionCliente { get => fechaInicioSuspensionCliente; set => fechaInicioSuspensionCliente = value; }
        public DateTime FechaFinSuspensionCliente { get => fechaFinSuspensionCliente; set => fechaFinSuspensionCliente = value; }


    }
}
