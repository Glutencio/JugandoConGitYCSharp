using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoLibro
{
    public class Alumno
    {
        private int _dni;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;

        public Alumno() { }

        public Alumno(int dni, string nombre, string apellido, DateTime fechaNacimiento)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNacimiento = fechaNacimiento;
        }

        public int dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }
        }

        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public string mostrarDatos() 
        {
            string strDatos;

            strDatos = $"DNI: {this.dni} Nombre: {this.nombre} {this.apellido}";
            return strDatos;
        }


    }
}