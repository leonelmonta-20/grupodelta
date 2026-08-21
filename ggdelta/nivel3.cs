using System;

namespace ggdelta
{
    public static class Nivel3
    {
        // Ejercicio 21: Positivo, negativo o cero
        public static void Ejercicio21()
        {
            Console.Write("Ingrese un número entero: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("El número es POSITIVO.");
            }
            else if (num < 0)
            {
                Console.WriteLine("El número es NEGATIVO.");
            }
            else
            {
                Console.WriteLine("El número es CERO.");
            }
        }

        // Ejercicio 22: Mayor de 3 números distintos
        public static void Ejercicio22()
        {
            Console.Write("Ingrese el primer número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            double n3 = double.Parse(Console.ReadLine());

            if (n1 >= n2 && n1 >= n3)
            {
                Console.WriteLine("El mayor es: " + n1);
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine("El mayor es: " + n2);
            }
            else
            {
                Console.WriteLine("El mayor es: " + n3);
            }
        }

        // Ejercicio 23: Nota numérica (0-100) a letra
        public static void Ejercicio23()
        {
            Console.Write("Ingrese la calificación (0 - 100): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 90 && nota <= 100)
            {
                Console.WriteLine("Calificación: A");
            }
            else if (nota >= 80)
            {
                Console.WriteLine("Calificación: B");
            }
            else if (nota >= 70)
            {
                Console.WriteLine("Calificación: C");
            }
            else if (nota >= 60)
            {
                Console.WriteLine("Calificación: D");
            }
            else
            {
                Console.WriteLine("Calificación: F");
            }
        }

        // Ejercicio 24: Etapa de vida según edad
        public static void Ejercicio24()
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 0 && edad <= 12)
            {
                Console.WriteLine("Etapa: Niño");
            }
            else if (edad >= 13 && edad <= 17)
            {
                Console.WriteLine("Etapa: Adolescente");
            }
            else if (edad >= 18 && edad <= 64)
            {
                Console.WriteLine("Etapa: Adulto");
            }
            else if (edad >= 65)
            {
                Console.WriteLine("Etapa: Adulto mayor");
            }
            else
            {
                Console.WriteLine("Edad no válida.");
            }
        }

        // Ejercicio 25: Calculadora básica con menú
        public static void Ejercicio25()
        {
            Console.Write("Ingrese el primer número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Elija una operación:");
            Console.WriteLine("1: Suma | 2: Resta | 3: Multiplicación | 4: División");
            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Resultado Suma: " + (n1 + n2));
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Resultado Resta: " + (n1 - n2));
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Resultado Multiplicación: " + (n1 * n2));
            }
            else if (opcion == 4)
            {
                if (n2 != 0)
                {
                    Console.WriteLine("Resultado División: " + (n1 / n2));
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        // Ejercicio 26: Día de la semana (1 a 7)
        public static void Ejercicio26()
        {
            Console.Write("Ingrese un número del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine());

            if (dia == 1)
            {
                Console.WriteLine("Lunes");
            }
            else if (dia == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (dia == 3)
            {
                Console.WriteLine("Miércoles");
            }
            else if (dia == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (dia == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (dia == 6)
            {
                Console.WriteLine("Sábado");
            }
            else if (dia == 7)
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                Console.WriteLine("Error: Número fuera de rango (debe ser del 1 al 7).");
            }
        }

        // Ejercicio 27: Índice de Masa Corporal (IMC)
        public static void Ejercicio27()
        {
            Console.Write("Ingrese su peso en kilogramos: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su estatura en metros (ejemplo 1.70): ");
            double estatura = double.Parse(Console.ReadLine());

            double imc = peso / (estatura * estatura);
            Console.WriteLine("Su IMC es: " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Categoría: Bajo peso");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Categoría: Normal");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Categoría: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Categoría: Obesidad");
            }
        }

        // Ejercicio 28: Sistema de peaje por tipo de vehículo
        public static void Ejercicio28()
        {
            Console.Write("Ingrese el tipo de vehículo (Moto, Auto, Autobus, Camion): ");
            string tipo = Console.ReadLine().ToLower().Trim();

            if (tipo == "moto")
            {
                Console.WriteLine("Tarifa de peaje: $2");
            }
            else if (tipo == "auto")
            {
                Console.WriteLine("Tarifa de peaje: $5");
            }
            else if (tipo == "autobus" || tipo == "autobús")
            {
                Console.WriteLine("Tarifa de peaje: $10");
            }
            else if (tipo == "camion" || tipo == "camión")
            {
                Console.WriteLine("Tarifa de peaje: $15");
            }
            else
            {
                Console.WriteLine("Vehículo no reconocido.");
            }
        }

        // Ejercicio 29: Tipo de triángulo según sus lados
        public static void Ejercicio29()
        {
            Console.Write("Ingrese el lado 1: ");
            double l1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado 2: ");
            double l2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado 3: ");
            double l3 = double.Parse(Console.ReadLine());

            if (l1 == l2 && l2 == l3)
            {
                Console.WriteLine("El triángulo es EQUILÁTERO (3 lados iguales).");
            }
            else if (l1 == l2 || l1 == l3 || l2 == l3)
            {
                Console.WriteLine("El triángulo es ISÓSCELES (2 lados iguales).");
            }
            else
            {
                Console.WriteLine("El triángulo es ESCALENO (3 lados diferentes).");
            }
        }

        // Ejercicio 30: Semáforo
        public static void Ejercicio30()
        {
            Console.Write("Ingrese el color del semáforo (rojo, amarillo, verde): ");
            string color = Console.ReadLine().ToLower().Trim();

            if (color == "rojo")
            {
                Console.WriteLine("Detenerse");
            }
            else if (color == "amarillo")
            {
                Console.WriteLine("Precaución");
            }
            else if (color == "verde")
            {
                Console.WriteLine("Avanzar");
            }
            else
            {
                Console.WriteLine("Color no válido.");
            }
        }
    }
}