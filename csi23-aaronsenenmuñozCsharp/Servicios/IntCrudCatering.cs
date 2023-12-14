using DAL;
using System.Runtime.CompilerServices;

namespace csi23_aaronsenenmuñozCsharp.Servicios
{
    /// <summary>
    /// Interzas para hacer el crud a la base de datos
    /// <author>ASMP 14-12-23</author>
    /// </summary>
    public interface IntCrudCatering
    {
        /// <summary>
        /// Interzas para hacer el crud a la base de datos
        /// <author>ASMP 14-12-23</author>
        /// </summary>
        void InsertarVajilla(Contexto conexto, Vajilla vajilla);
        /// <summary>
        ///Metodo para buscar todas las vajilla
        ///<author>ASMP 14-12-23</author>
        /// </summary>
        List<Vajilla> BuscarVajillaTodas(Contexto contexto);
        /// <summary>
        /// Metodo para buscar una vajilla concreta
        /// <author>ASMP 14-12-23</author>
        /// </summary>
        Vajilla BuscarVajillaUna(Contexto contexto, string codigo);
        /// <summary>
        /// Metodo para buscar un prestamo concreta
        /// <author>ASMP 14-12-23</author>
        /// </summary>
        List<Prestamo> BuscarPrestamo(Contexto contexto);

        /// <summary>
        /// Metodo para insertar prestamo
        /// <author>ASMP 14-12-23</author>
        /// </summary>
        void InsertarPrestamo(Contexto contexto, Prestamo presta);

        /// <summary>
        /// Metodo para insertar Reserva de vajilla prestamo
        /// <author>ASMP 14-12-23</author>
        /// </summary>
        void InsertarRelVajillaPresta(Contexto contexto, Rel_Vajilla_Prestamo presta);

    }
}
