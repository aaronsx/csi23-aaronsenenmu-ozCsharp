using DAL;

namespace csi23_aaronsenenmuñozCsharp.Servicios
{
    /// <summary>
    /// Interzas para hacer la logica del Catering
    /// <author>ASMP 14-12-23</author>
    /// </summary>
    public interface IntServCatering
    {
        /// <summary>
        /// 
        /// <author>ASMP 14-12-23</author>
        /// </summary>
        void MostrarStock(Contexto contexto);
        /// <summary>
        /// 
        /// <author>ASMP 14-12-23</author>
        /// </summary>
        void AñadirVajilla(Contexto contexto);
        /// <summary>
        /// 
        /// <author>ASMP 14-12-23</author>
        /// </summary>
        void CrearReserva(Contexto contexto);

    }
}
