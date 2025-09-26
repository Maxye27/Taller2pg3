using System;

namespace Taller2pg
{
    public class persona
    {

        public string Nombre { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string Ocupacion { get; set; }
        public string Ciudad { get; set; }
        public string Estadocivil { get; set; }

        public persona()
        {
            Nombre = "";
            Peso = 0f;
            Altura = 0f;
            Edad = 0;
            Genero = "";
            Ocupacion = "";
            Ciudad = "";
            Estadocivil = "";
        }
        public float imc()
        {
            return Peso / (Altura * Altura);
        }
    }
}