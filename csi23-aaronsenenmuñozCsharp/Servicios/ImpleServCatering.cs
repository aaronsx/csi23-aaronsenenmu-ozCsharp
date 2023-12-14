using DAL;
using System.Security.Cryptography;

namespace csi23_aaronsenenmuñozCsharp.Servicios
{
    /// <summary>
    /// 
    /// <author>ASMP 14-12-23</author>
    /// </summary>
    public class ImpleServCatering : IntServCatering
    {
        public void AñadirVajilla(Contexto contexto)
        {
            int numVajilla=0;
            Console.WriteLine("Dime el nombre de la vajilla");
            string nombre=Console.ReadLine();
            Console.WriteLine("Dime la descripcion de la vajilla");
            string descripcion = Console.ReadLine();
            do
            {
                Console.WriteLine("Dime la cantidad de la vajilla");
                numVajilla = Convert.ToInt32(Console.ReadLine());
                if(numVajilla == 0)
                   Console.WriteLine("Lo siento la cantidad no puede ser 0");
            } while (numVajilla == 0);

            Vajilla vajilla = new Vajilla(String.Format("Elem-"+nombre),nombre,descripcion,numVajilla);
             IntCrudCatering crudCatering = new ImpCrudCatering();
            crudCatering.InsertarVajilla(contexto,vajilla);
        }

        public void CrearReserva(Contexto contexto)
        {
            DateTime fchPrestamo = new DateTime(9999,12,31);
            int numVajilla = 0;
            int cantidad = 0;
            Console.WriteLine("Dime el codigo  de la vajilla");
            string codigo = Console.ReadLine();
            IntCrudCatering crudCatering = new ImpCrudCatering();
            Vajilla vaji=crudCatering.BuscarVajillaUna(contexto, codigo);
            if (vaji != null) {
                do
                {
                    Console.WriteLine("Dime la cantidad de la vajilla");
                    numVajilla = Convert.ToInt32(Console.ReadLine());
                    if (vaji.cantidadVajilla <= numVajilla)
                    {
                        Console.WriteLine("Dime el año de la reserva");
                        int anyo=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dime el mes de la reserva (en numerico)");
                        int mes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dime el dia");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        fchPrestamo = new DateTime(anyo, mes, dia);

                    }
                } while (vaji.cantidadVajilla > numVajilla);

                Prestamo pres=new Prestamo(fchPrestamo);
                crudCatering.InsertarPrestamo(contexto,pres);
                List<Prestamo> prestamoList =crudCatering.BuscarPrestamo(contexto);
                foreach (Prestamo pre in prestamoList) 
                {
                    if (pre.fchPrestamo == fchPrestamo)
                    {

                        Rel_Vajilla_Prestamo rel = new Rel_Vajilla_Prestamo(vaji.idVajilla, pre.idPrestamo, numVajilla);
                        crudCatering.InsertarRelVajillaPresta(contexto, rel);
                    }
                }
                
            }

        }

        public void MostrarStock(Contexto contexto)
        {
            IntCrudCatering crudCatering = new ImpCrudCatering();
            Console.WriteLine("Pulsa 1 si quieres mostrar todo y 2 si quieres mostrar uno");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                List<Vajilla> vajillalista = crudCatering.BuscarVajillaTodas(contexto);
                foreach (Vajilla v in vajillalista)
                {
                    Console.WriteLine("id: {0},codigo:{1},nombre:{2},descripcion:{3},cantidad:{4}",v.idVajilla,v.codigoVajilla,v.nombreVajilla,v.descripcionVajilla,v.cantidadVajilla);
                }
            } else if (num == 2) 
            {
                Console.WriteLine("Dime el codigo que quieres mostrar");
                string codigo = Console.ReadLine();
                Vajilla v=crudCatering.BuscarVajillaUna(contexto, codigo);
            
                  Console.WriteLine("id: {0},codigo:{1},nombre:{2},descripcion:{3},cantidad:{4}", v.idVajilla, v.codigoVajilla, v.nombreVajilla, v.descripcionVajilla, v.cantidadVajilla);
                
            }
            Console.ReadKey();
            
        }
    }
}
