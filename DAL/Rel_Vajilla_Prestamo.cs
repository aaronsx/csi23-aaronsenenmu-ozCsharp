using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    /// <summary>
    /// Clase de la entidad de Rel_Vajilla_Prestamo
    /// <author>ASMP 14-12-23</author>
    /// </summary>
    public class Rel_Vajilla_Prestamo
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idRelVajillaPrestamo { get; set; }

        public long idVajilla { get; set; }
        [ForeignKey("idVajilla")]
        public virtual Vajilla Vajilla { get; set; }

        public long idPrestamo { get; set; }
        [ForeignKey("idPrestamo")]
        public virtual Prestamo Prestamo { get; set; }

        public int cantidadVajillaPrestamo;
        public Rel_Vajilla_Prestamo()
        {
            
        }
        public Rel_Vajilla_Prestamo(long idVajilla, long idPrestamo, int cantidadVajillaPrestamo)
        {
            this.idVajilla = idVajilla;
            this.idPrestamo = idPrestamo;
            this.cantidadVajillaPrestamo = cantidadVajillaPrestamo;
        }
    }
}
