namespace ManejoString{
    public class Cadena01{
        public void Caso01(){
            //Creacion de objetos
            var nombre = (nombre1: "Erick", nombre2:"Calderon");
            Console.WriteLine($"{nombre.nombre1}");
        }
        public void SubCadena(){
            string primeraLinea = "Curso de Programacion C#.";
            Console.WriteLine("SubCadena: {0}", primeraLinea.Substring(9,11));
        }
    }
}
