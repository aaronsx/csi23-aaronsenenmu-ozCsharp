using DAL;

namespace csi23_aaronsenenmuñozCsharp.Servicios
{
    /// <summary>
    /// Clase que extiende de la interzas CrudCatering para hacer el crud a la base de datos
    /// <author>ASMP 14-12-23</author>
    /// </summary>
    public class ImpCrudCatering : IntCrudCatering
    {
        public List<Prestamo> BuscarPrestamo(Contexto contexto)
        {
            try
            {
                return contexto.prestamos.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("[Error-ImpCrudCatering-BuscarPrestamo] No se ha podido encontrar el prestamo");
            }
            return null;
        }

        public List<Vajilla> BuscarVajillaTodas(Contexto contexto)
        {
            try
            {
                List<Vajilla> vajillas = contexto.vajillas.ToList();
                return vajillas;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("[Error-ImpCrudCatering-BuscarVajillaTodas] No se encuentra ninguna vajilla");
            }
            return null;
        }

        public Vajilla BuscarVajillaUna(Contexto contexto, string codigo)
        {
            try {
                return contexto.vajillas.FirstOrDefault(v => v.codigoVajilla == codigo);
            }
            catch (ArgumentNullException ex) 
            { 
                Console.WriteLine("[Error-ImpCrudCatering-BuscarVajillaUna] No se ha podido encontrar la vajilla");
            }
            return null;
        }

       

        public void InsertarPrestamo(Contexto contexto, Prestamo presta)
        {
            contexto.Add<Prestamo>(presta);
            contexto.SaveChanges();
        }

        public void InsertarRelVajillaPresta(Contexto contexto, Rel_Vajilla_Prestamo presta)
        {
            contexto.Add<Rel_Vajilla_Prestamo>(presta);
            contexto.SaveChanges();
        }

        public void InsertarVajilla(Contexto contexto, Vajilla vajil)
        {
            contexto.Add<Vajilla>(vajil);
            contexto.SaveChanges();
        }
    }
}
