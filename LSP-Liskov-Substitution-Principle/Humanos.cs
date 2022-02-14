using System;
using System.Collections.Generic;

namespace LSP_Liskov_Substitution_Principle
{
    // Se implementa la interfaz IRutinas donde tenemos una rutinas que podriamos aplicar 
    // para los humanos pero también para una clase animales, y en cada clase se define la 
    // funcionalidad que tendría el método horasSueño por ejemplo, donde el humano por lo 
    // general duerme 1 vez al día pero los animales pueden tener varias siestas.
    public class Humano
    {
        public string Nombre { get; set; }

        public int NumeroIdentificacon { get; set; }

        public string Raza { get; set; }

        public string ColorOjos { get; set; }

        public double Estatura { get; set; }

        public double Peso { get; set; }

        public string TipoSangre { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public int horasSueno(int[] hora, int[] horaDespertar)
        {
            int horasSueño = horaDespertar[0] - hora[0];
            return horasSueño;
        }

        public int horasEjercicio(bool practica, int horaInicio, int horaSalida)
        {
            if (practica)
            {
                int horasEjercicio = horaInicio - horaSalida;
                return horasEjercicio;
            }
            return 0;
        }

        public string[] hobbies(string[] hobbies)
        {
            string[] arregloHobbies = new string[] { "Montar bicicleta", "Caminar" };
            return arregloHobbies;
        }
    }
}
