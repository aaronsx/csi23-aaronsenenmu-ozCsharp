using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Clase de la entidad de prestamo
    /// <author>ASMP 14-12-23</author>
    /// </summary>
    public class Prestamo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idPrestamo { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime fchPrestamo { get; set; }

        public Prestamo(DateTime fchPrestamo)
        {
            this.fchPrestamo = fchPrestamo;
        }
        public Prestamo()
        {

        }
    }
}
