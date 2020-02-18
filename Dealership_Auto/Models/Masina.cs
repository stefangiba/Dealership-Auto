using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership_Auto.Models
{
    public class Masina
    {
        public int MasinaID { get; set; }
        //public int TranzactieID { get; set; }
        public int ModelID { get; set; }
        public string Model { get; set; }
        public string Producator { get; set; }
        public int Pret { get; set; }
        public string Motorizare { get; set; }
        public string Combustibil { get; set; }
        public string Culoare { get; set; }
        public String AnFabricatie { get; set; }
        public int KM { get; set; }
        public string Descriere { get; set; }
    }
}
