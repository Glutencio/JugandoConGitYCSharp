using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoLibro
{
    public class Libro
    {
        //Atributos autoimplementados

        public string titulo { get; private set; }

        public Autor autor { get; private set; }

        public Genero genero { get; private set; }

        public Editorial editorial { get; private set; }

        public Libro(string t, Autor a,Genero g, Editorial e ) 
        {
            titulo = t;
            autor = a;
            genero = g;
            editorial = e;
        }
    }
}
