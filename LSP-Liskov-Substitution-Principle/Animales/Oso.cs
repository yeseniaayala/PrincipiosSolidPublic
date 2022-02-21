using System;
using System.Collections.Generic;
using LSP_Liskov_Substitution_Principle.Interfaces;


namespace LSP_Liskov_Substitution_Principle.Animales
{
    public class Oso : IRutinasAnimalesHibernan
    {
        string IRutinasAnimalesHibernan.raza { get => "Polar"; set { } }
        string[] IRutinasAnimalesHibernan.comida { get => new string[1] { "focas"}; set { } }
        string IRutinasAnimalesHibernan.tipoAnimal { get => "Vertebrado"; set { } }

       
        public List<string> cazar()
        {
            List<string> animalesCaza = new List<string>() { "Focas" };
            return animalesCaza;
        }

        public string comer()
        {
            return "Los osos comen durante el 50% del día";
        }

        public string criar()
        {
            return "Los osos crian a sus oseznos  durante 18 meses";
        }

        public string dormir()
        {
            return "Los osos duermen durante 24 horas";
        }

        public string hibernar()
        {
            return "Los osos hibernan  durante 7 meses";
        }

        public string jugar()
        {
            return "Los osos juegan durante su crianza";
        }
    }
}
