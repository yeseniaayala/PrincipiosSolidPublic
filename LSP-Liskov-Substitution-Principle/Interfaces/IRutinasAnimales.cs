using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Liskov_Substitution_Principle.Interfaces
{
    public interface IRutinasAnimales
    {
        public string raza { get; set; }
        public string[] comida { get; set; }
        public string tipoAnimal { get; set; }
        string dormir();
        List<string> cazar();
        string comer();
        string criar();
        string jugar();
    }
}
