using System;
using LSP_Liskov_Substitution_Principle.Interfaces;
using System.Collections.Generic;

namespace LSP_Liskov_Substitution_Principle.Animales
{
    public class Tigre : IRutinasAnimales
    {
        string IRutinasAnimales.raza { get => "Vengala"; set { } }
        string[] IRutinasAnimales.comida { get => new string[2] { "Venado", "Kanguro" }; set { } }
        string IRutinasAnimales.tipoAnimal { get => "Vertebrado"; set { } }

        public List<string> cazar()
        {
            List<string> animalesCaza = new List<string>() { "Venado", "Kanguro" };
            return animalesCaza;
        }

        public string comer()
        {
            return "Los tigres cazan una vez por semana";
        }

        public string criar()
        {
            return "Los tigres crian a sus hijos durante 2 años";
        }

        public string dormir()
        {
            return "Los tigres duermen varias siestas durante el día";
        }

        public string jugar()
        {
            return "Los osos juegan durante su crianza";
        }
    }
}
