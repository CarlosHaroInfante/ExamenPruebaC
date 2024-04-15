using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamenC.Dtos
{
    internal class puertasDto
    {
        string puertaSur = "sur";
        string puertaOeste = "oeste";
        string puertaEste = "este";
        string puertaPif = "pif";
        string puertaNorte = "norte";
        string puertaEsteNorte = "este norte";
        bool revision = false;
        DateTime fechaPasoPuerta = DateTime.Now;

        public puertasDto(string puertaSur, string puertaOeste, string puertaEste, string puertaPif, string puertaNorte, string puertaEsteNorte, bool revision, DateTime fechaPasoPuerta)
        {
            this.puertaSur = puertaSur;
            this.puertaOeste = puertaOeste;
            this.puertaEste = puertaEste;
            this.puertaPif = puertaPif;
            this.puertaNorte = puertaNorte;
            this.puertaEsteNorte = puertaEsteNorte;
            this.revision = revision;
            this.fechaPasoPuerta = fechaPasoPuerta;
        }

        public string PuertaSur { get => puertaSur; set => puertaSur = value; }
        public string PuertaOeste { get => puertaOeste; set => puertaOeste = value; }
        public string PuertaEste { get => puertaEste; set => puertaEste = value; }
        public string PuertaPif { get => puertaPif; set => puertaPif = value; }
        public string PuertaNorte { get => puertaNorte; set => puertaNorte = value; }
        public string PuertaEsteNorte { get => PuertaEsteNorte; set => PuertaEsteNorte = value; }
        public bool Revision { get => revision; set => revision = value; }
        public DateTime FechaPasoPuerta { get => fechaPasoPuerta; set => fechaPasoPuerta = value; }

        public puertasDto()
        {

        }

        public string ToString()
        {
            string puerta = "Revisión: " + this.revision + " Fecha de Paso por puerta: " + this.FechaPasoPuerta;
            return puerta;
        }
    }
}
