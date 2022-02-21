using LSP_Liskov_Substitution_Principle.Interfaces;
using System.Collections.Generic;

namespace LSP_Liskov_Substitution_Principle.Animales
{
    public class Delfin : IRutinasAnimalesNoDuermen
    {       
        string IRutinasAnimalesNoDuermen.raza { get { return "Rosado"; }  set { } }
        string[] IRutinasAnimalesNoDuermen.comida { get => new string[2] { "Arenque", "Bacalo" }; set { } }
        string IRutinasAnimalesNoDuermen.tipoAnimal { get => "Vertebrado"; set => throw new System.NotImplementedException(); }

        public List<string> cazar()
        {
            List<string> animalesCaza = new List<string>() { "Peces", "Calamares" };
            return animalesCaza;
        }

        public string comer()
        {
            return "Los delfines comen durante todo el día";
        }

        public string criar()
        {
            return "Los delfines crian a sus hijos durante 2 años";
        }

        public string jugar()
        {
            return "Los delfines juegan durante su crianza";
        }
    }
}
