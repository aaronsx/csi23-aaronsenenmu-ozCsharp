using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL
{
    /// <summary>
    /// Clase de la entidad de Vajilla
    /// <author>ASMP 14-12-23</author>
    /// </summary>
    public class Vajilla
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idVajilla { get; set; }
        public string codigoVajilla { get; set; }

        public string nombreVajilla { get; set; }

        public string descripcionVajilla { get; set; }

        public int cantidadVajilla { get; set; }

        public Vajilla()
        {
            
        }
        public Vajilla(string codigoVajilla, string nombreVajilla, string descripcionVajilla, int cantidadVajilla)
        {
            this.codigoVajilla = codigoVajilla;
            this.nombreVajilla = nombreVajilla;
            this.descripcionVajilla = descripcionVajilla;
            this.cantidadVajilla = cantidadVajilla;
        }
        public Vajilla(long idVajilla, string codigoVajilla, string nombreVajilla, string descripcionVajilla, int cantidadVajilla)
        {
            this.idVajilla = idVajilla;
            this.codigoVajilla = codigoVajilla;
            this.nombreVajilla = nombreVajilla;
            this.descripcionVajilla = descripcionVajilla;
            this.cantidadVajilla = cantidadVajilla;
        }

    }
}
