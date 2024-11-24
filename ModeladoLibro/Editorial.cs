using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoLibro
{
    public class Editorial
    {
        private int _id;
        private string _nombre;

        public Editorial(int id, string nombre) 
        {
            _id = id;
            _nombre = nombre;   
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public override string ToString()
        {
            return $"El id es: {id} nombre: {nombre}";
        }
    }
}
