using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamenC.Dtos
{
    internal class vehiculosDto
    {
        long id;
        string matricula = "aaaaa";
        string tipoVehiculo = "aaaaa";
        string zonaDestino = "aaaaa";
        bool mercancia = false;
        DateTime fechaPasoControl = DateTime.Now;

        public vehiculosDto(long id, string matricula, string tipoVehiculo, string zonaDestino, bool mercancia, DateTime fechaPasoControl)
        {
            this.id = id;
            this.matricula = matricula;
            this.tipoVehiculo = tipoVehiculo;
            this.zonaDestino = zonaDestino;
            this.mercancia = mercancia;
            this.fechaPasoControl = fechaPasoControl;
        }

        public long Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string ZonaDestino { get => zonaDestino; set => zonaDestino = value; }
        public bool Mercancia { get => mercancia; set => mercancia = value; }
        public DateTime FechaPasoControl { get => fechaPasoControl; set => fechaPasoControl = value; }


        public vehiculosDto()
        {

        }

        public string ToString()
        {
            string vehiculo = "id: " + this.id + " Matricula: " + this.matricula + " Tipo de Vehiculo: "
                + this.tipoVehiculo + " Zona de Destino: " + this.ZonaDestino + " mercancia: " + this.mercancia
                + " Fecha de paso por control: " + this.fechaPasoControl;

            return vehiculo;
        }
    }
}
