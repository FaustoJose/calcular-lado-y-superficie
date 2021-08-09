using System;

namespace calcular_lado_y_superficie
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado(5);
        }
        public static void Cuadrado(int lado)
        {
            int perimetro=4*lado;
            int superficie= lado*lado ;
            Console.WriteLine("el perimetro es: "+perimetro+" la superficie es: "+superficie);
        }
    }
}
