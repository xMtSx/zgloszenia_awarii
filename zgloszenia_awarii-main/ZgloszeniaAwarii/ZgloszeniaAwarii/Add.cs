using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awaria.models
{
    internal class Add
    {
        public int ID { get; set; }
        public string NazwaUzytkownika { get; set; }
        public string Opis { get; set; }
        public string DataDodania { get; set; }
        public string PrzydzieloneDo { get; set; }
        public bool Wykonane { get; set; }
    }
}
