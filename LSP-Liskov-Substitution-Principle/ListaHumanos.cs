using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Liskov_Substitution_Principle
{
    public class ListaHumanos
    {
        // Aqui estamos creando una instancia de la clase humano
        // es decir tenemos el objeto Paola y el objeto Walter cada uno con sus 
        // propios atributos o características.
        // La clase me permite definir cuales serán los atributos y métodos que tendrá mi objeto
        public Humano paola = new Humano()
        {
            ColorOjos = "Café",
            Ciudad = "Chía",
            Estatura = 1.60,
            Nombre = "Paola",
            NumeroIdentificacon = 111,
            Pais = "Colombia",
            Peso = 60,
            Raza = "Meztizo",
            TipoSangre = "O+",
        };

        Humano walter = new Humano()
        {
            ColorOjos = "Café",
            Ciudad = "Bogotá",
            Estatura = 1.80,
            Nombre = "Walter",
            NumeroIdentificacon = 886556,
            Pais = "Colombia",
            Peso = 80,
            Raza = "Blanco",
            TipoSangre = "O-",
        };

        public List<Humano> ListHumanos()
        {
            List<Humano> listHumanos = new List<Humano>();

            listHumanos.Add(paola);
            listHumanos.Add(walter);

            return listHumanos;
        }
    }
}
