using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership_Auto.Models
{
    public class Tranzactie
    {
        public int TranzactieID { get; set; }
        public int MasinaID { get; set; }
        public int AngajatID { get; set; }
        public int ClientID { get; set; }
        public string Data { get; set; }
        public double Suma { get; set; }
        public Masina masina { get; set; }
        public Angajat angajat { get; set; }
        public Client client { get; set; }
    }
}
