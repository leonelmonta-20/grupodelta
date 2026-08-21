using System;

namespace ggdelta
{
    public static class Nivel1
    {
        public static void Ejercicio01()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido a Programación II, " + nombre);
        }

        public static void Ejercicio02()
        {
            const double PI = 3.14159;
            Console.Write("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());
            double area = PI * radio * radio;
            Console.WriteLine("El área del círculo es: " + area);
        }

        public static void Ejercicio03()
        {
            Console.Write("Ingrese su año de nacimiento: ");
            int anioNacimiento = int.Parse(Console.ReadLine());
            int edad = DateTime.Now.Year - anioNacimiento;
            Console.WriteLine("Su edad aproximada es: " + edad + " años");
        }

        public static void Ejercicio04()
        {
            const double IVA = 0.13;
            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());
            double total = precio + (precio * IVA);
            Console.WriteLine("Precio final con IVA: " + total);
        }

        public static void Ejercicio05()
        {
            Console.Write("Primer número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Suma: " + (n1 + n2));
            Console.WriteLine("Resta: " + (n1 - n2));
            Console.WriteLine("Multiplicación: " + (n1 * n2));
            if (n2 != 0)
                Console.WriteLine("División: " + (n1 / n2));
            else
                Console.WriteLine("No se puede dividir entre cero.");
        }

        public static void Ejercicio06()
        {
            Console.Write("Nota 1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Promedio final: " + ((n1 + n2 + n3) / 3));
        }

        public static void Ejercicio07()
        {
            int a = 5, b = 10;
            Console.WriteLine("Original -> a: " + a + ", b: " + b);
            int aux = a;
            a = b;
            b = aux;
            Console.WriteLine("Intercambiado -> a: " + a + ", b: " + b);
        }

        public static void Ejercicio08()
        {
            Console.Write("Temperatura en °C: ");
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine("En Fahrenheit: " + f + " °F");
        }

        public static void Ejercicio09()
        {
            Console.Write("Cantidad de minutos: ");
            int totalMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Equivale a: " + (totalMin / 60) + " hora(s) y " + (totalMin % 60) + " minuto(s)");
        }

        public static void Ejercicio10()
        {
            Console.Write("Número 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 != 0)
                Console.WriteLine("Residuo (%): " + (num1 % num2));
            else
                Console.WriteLine("El segundo número no puede ser cero.");
        }
    }
}
