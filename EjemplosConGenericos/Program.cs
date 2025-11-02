using System;

namespace EjemploGenericos
{
    // Clase genérica que funciona con cualquier tipo T
    public class Operaciones<T>
    {
        private T _valor1;
        private T _valor2;

        // Constructor genérico
        public Operaciones(T valor1, T valor2)
        {
            _valor1 = valor1;
            _valor2 = valor2;
        }

        // Mostrar los valores
        public void MostrarValores()
        {
            Console.WriteLine($"Valor 1: {_valor1}");
            Console.WriteLine($"Valor 2: {_valor2}");
        }

        // Intercambiar los valores
        public void Intercambiar()
        {
            T temp = _valor1;
            _valor1 = _valor2;
            _valor2 = temp;
        }

        // Verificar si los valores son iguales
        public bool SonIguales()
        {
            return _valor1.Equals(_valor2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJEMPLO GENÉRICOS EN C# ===\n");

            // Usando int
            var opEnteros = new Operaciones<int>(10, 20);
            Console.WriteLine("👉 Operaciones con enteros:");
            opEnteros.MostrarValores();
            opEnteros.Intercambiar();
            Console.WriteLine("Después de intercambiar:");
            opEnteros.MostrarValores();

            Console.WriteLine($"¿Son iguales? {opEnteros.SonIguales()}");

            Console.WriteLine("\n------------------------------\n");

            // Usando string
            var opTextos = new Operaciones<string>("Hola", "Mundo");
            Console.WriteLine("👉 Operaciones con textos:");
            opTextos.MostrarValores();
            opTextos.Intercambiar();
            Console.WriteLine("Después de intercambiar:");
            opTextos.MostrarValores();

            Console.WriteLine($"¿Son iguales? {opTextos.SonIguales()}");
        }
    }
}
