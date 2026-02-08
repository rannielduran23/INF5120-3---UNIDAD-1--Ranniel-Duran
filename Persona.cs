using System;

namespace INF512_Unidad1_POO
{
    public class Persona
    {
        // Atributos (estado)
        private string nombre;
        private int edad;
        private string cedula;

        // Constructor
        public Persona(string nombre, int edad, string cedula)
        {
            this.nombre = nombre;
            this.edad = edad >= 0 ? edad : 0;
            this.cedula = cedula;
        }

        // Métodos (comportamiento)
        public void CumplirAnios()
        {
            edad++;
        }

        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }

        public string ObtenerInformacion()
        {
            return $"Nombre: {nombre}, Edad: {edad}, Cédula: {cedula}";
        }

        // Métodos de acceso controlado (encapsulamiento)
        public string ObtenerNombre()
        {
            return nombre;
        }

        public int ObtenerEdad()
        {
            return edad;
        }

        public void ActualizarNombre(string nuevoNombre)
        {
            if (!string.IsNullOrWhiteSpace(nuevoNombre))
            {
                nombre = nuevoNombre;
            }
        }
    }
}
