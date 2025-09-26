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
        public string ClasificarIMC()
        {
            float indice = imc();
            if (indice < 18.5)
            {
                return "Bajo peso: Riesgo de deficiencias nutricionales, anemia y osteoporosis.";
            }
            else if (indice >= 18.5 && indice <= 24.9)
            {
                return "Normal: Riesgo bajo; estado saludable.";
            }
            else if (indice >= 25 && indice <= 29.9)
            {
                return "Sobrepeso: Riesgo aumentado de enfermedades cardiovasculares, hipertensión y diabetes.";
            }
            else if (indice >= 30 && indice <= 34.9)
            {
                return "Obesidad Tipo I (moderada): Riesgo alto de diabetes tipo 2, hipertensión y problemas cardiovasculares.";
            }
            else if (indice >= 35 && indice <= 39.9)
            {
                return "Obesidad Tipo II (severa): Riesgo muy alto de complicaciones graves: infartos, apnea del sueño, artrosis.";
            }
            else
            {
                return "Obesidad Tipo III (mórbida): Riesgo extremadamente alto: enfermedades cardiovasculares, metabólicas y mayor mortalidad.";
            }
        }
    }
}