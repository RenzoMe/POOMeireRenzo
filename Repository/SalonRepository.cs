using System.Collections.Generic;
using POOMeireRenzo.Model;

namespace POOMeireRenzo.Repository
{
    public class SalonRepository
    {
        private static SalonRepository? instancia;
        public static SalonRepository Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new SalonRepository();
                }
                return instancia;
            }
        }

        private List<Salon> listaSalones;

        private SalonRepository()
        {
            this.listaSalones = new List<Salon>
            {
                new Salon(1, "Salón Ismael", 2500000m, 100000m),
                new Salon(2, "Salón Golondrinas", 2000000m, 80000m),
                new Salon(3, "Salón OASIS", 4000000m, 150000m)
            };
        }

        public List<Salon> ObtenerTodos()
        {
            return this.listaSalones;
        }
    }
}