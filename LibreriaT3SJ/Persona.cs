using System;
using System.ComponentModel;

namespace LibreriaT3SJ
{
    public class Persona
    {
        private String _cedula;
        [DisplayName("Cedula")]
        public String Cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }

        private String _nombre;
        [DisplayName("Nombre")]
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        private String _apellido1;
        [DisplayName("Primer Apellido")]
        public String Apellido1
        {
            get { return _apellido1; }
            set { _apellido1 = value; }
        }

        private String _apellido2;
        [DisplayName("Segundo Apellido")]
        public String Apellido2
        {
            get { return _apellido2; }
            set { _apellido2 = value; }
        }

        private Provincia _provincia1;
        [DisplayName("Provincia")]
        public Provincia Provincia1
        {
            get { return _provincia1; }
            set { _provincia1 = value; }
        }

        private Genero _genero;

        [DisplayName("Genero")]
        public Genero Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public Persona()
        {
            this._cedula = "0";
        }
    }

    public enum Provincia
    {
        SanJose,
        Alajuela,
        Cartago,
        Heredia,
        Puntarenas,
        Guanacaste,
        Limon
    }

    public enum Genero
    {
        Femenino,
        Masculino,
        NoIndica,
        Otro
    }
}
