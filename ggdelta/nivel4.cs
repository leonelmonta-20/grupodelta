using System;

namespace ggdelta
{
    // Ejercicio 37: Clase Calculadora con operaciones matemáticas
    public static class Calculadora
    {
        public static double Sumar(double a, double b)
        {
            return a + b;
        }

        public static double Restar(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
                return 0;
            }
            return a / b;
        }
    }

    public static class Nivel4
    {
        // Ejercicio 31: Método void Saludar
        public static void Saludar(string nombre)
        {
            Console.WriteLine("Hola " + nombre + ", bienvenido a C#");
        }

        // Ejercicio 32: Función bool EsPar
        public static bool EsPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Ejercicio 33: Función CalcularMayor
        public static double CalcularMayor(double n1, double n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        // Ejercicio 34: Función para dividir con validación de divisor 0
        public static double DividirConValidacion(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Error: El divisor no puede ser cero.");
                return 0;
            }
            return dividendo / divisor;
        }

        // Ejercicio 35: Función que retorna Tupla de Coordenadas (X, Y)
        public static (double x, double y) PedirCoordenadas()
        {
            Console.Write("Ingrese la coordenada X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la coordenada Y: ");
            double y = double.Parse(Console.ReadLine());

            return (x, y);
        }

        // Ejercicio 36: Función que retorna Tupla de Usuario (Nombre, Edad, Cargo)
        public static (string, int, string) ObtenerDatosUsuario()
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el cargo: ");
            string cargo = Console.ReadLine();

            return (nombre, edad, cargo);
        }

        // Ejercicio 38: Método con double.TryParse para evitar letras
        public static double PedirNumeroSeguro(string mensaje)
        {
            double numero;
            bool esValido = false;

            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                esValido = double.TryParse(entrada, out numero);

                if (!esValido)
                {
                    Console.WriteLine("Error: Debe escribir un número válido, no letras.");
                }
            } while (!esValido);

            return numero;
        }

        // Ejercicio 39: Integración de Salario con Tupla
        public static (double SalarioBruto, double DescuentoSeguro, double SalarioNeto) CalcularSalario(double salarioBruto)
        {
            double descuentoSeguro = salarioBruto * 0.10; // 10% de seguro
            double salarioNeto = salarioBruto - descuentoSeguro;

            return (salarioBruto, descuentoSeguro, salarioNeto);
        }

        // Ejercicio 40: Menú interactivo
        public static void MostrarMenu()
        {
            Console.WriteLine("--- SUBMENÚ EJERCICIO 40 ---");
            Console.WriteLine("1. Calcular área de un triángulo");
            Console.WriteLine("2. Evaluar si un número es par");
            Console.WriteLine("3. Determinar el mayor de 3 números");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Base: ");
                double baseT = double.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine());
                double area = (baseT * altura) / 2;
                Console.WriteLine("El área del triángulo es: " + area);
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine());
                if (EsPar(num))
                {
                    Console.WriteLine("El número es PAR.");
                }
                else
                {
                    Console.WriteLine("El número es IMPAR.");
                }
            }
            else if (opcion == 3)
            {
                Console.Write("Número 1: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.Write("Número 2: ");
                double n2 = double.Parse(Console.ReadLine());
                Console.Write("Número 3: ");
                double n3 = double.Parse(Console.ReadLine());

                double mayor = n1;
                if (n2 > mayor) mayor = n2;
                if (n3 > mayor) mayor = n3;

                Console.WriteLine("El mayor de los tres es: " + mayor);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}