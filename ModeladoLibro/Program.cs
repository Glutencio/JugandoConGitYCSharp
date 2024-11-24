namespace ModeladoLibro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modelado libro");
            //Creo un objeto tipo Autor
            //Autor autor1 = new Autor("Borgues", "Jose Luis");
            //Console.WriteLine(autor1.ToString());

            //Creando alumno
            Alumno alumno1 = new Alumno(4001101, "Uriel", "Barrios", Convert.ToDateTime("15/11/1996"));
            Alumno alumno2 = new Alumno();
            alumno2.dni = 11384976;
            alumno2.apellido = "Garcia";
            alumno2.nombre = "Jimena";
            alumno2.fechaNacimiento = Convert.ToDateTime("10/3/2002");
            Console.WriteLine(alumno2.mostrarDatos());



            Console.ReadKey();
        }
    }
}
