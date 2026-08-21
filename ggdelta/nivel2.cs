using System;

namespace ggdelta
{
    public static class Nivel2
    {
        // Ejercicio 11: Mayor o menor de edad
        public static void Ejercicio11()
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Es menor de edad.");
            }
        }

        // Ejercicio 12: Número par o impar
        public static void Ejercicio12()
        {
            Console.Write("Ingrese un número entero: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El número es PAR.");
            }
            else
            {
                Console.WriteLine("El número es IMPAR.");
            }
        }

        // Ejercicio 13: Mayor de dos números
        public static void Ejercicio13()
        {
            Console.Write("Ingrese el primer número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("El mayor es: " + n1);
            }
            else if (n2 > n1)
            {
                Console.WriteLine("El mayor es: " + n2);
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }
        }

        // Ejercicio 14: Positivo o negativo
        public static void Ejercicio14()
        {
            Console.Write("Ingrese un número: ");
            double num = double.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("El número es POSITIVO.");
            }
            else
            {
                Console.WriteLine("El número es NEGATIVO.");
            }
        }

        // Ejercicio 15: Aprobar o reprobar (mínimo 51)
        public static void Ejercicio15()
        {
            Console.Write("Ingrese la nota final (1 - 100): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 51)
            {
                Console.WriteLine("Estudiante Aprobado.");
            }
            else
            {
                Console.WriteLine("Estudiante Reprobado.");
            }
        }

        // Ejercicio 16: Validación de contraseña
        public static void Ejercicio16()
        {
            const string CLAVE_CORRECTA = "1234";

            Console.Write("Ingrese la contraseña: ");
            string clave = Console.ReadLine();

            if (clave == CLAVE_CORRECTA)
            {
                Console.WriteLine("Acceso permitido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
        }

        // Ejercicio 17: Año bisiesto (divisible entre 4)
        public static void Ejercicio17()
        {
            Console.Write("Ingrese un año: ");
            int año = int.Parse(Console.ReadLine());

            if (año % 4 == 0)
            {
                Console.WriteLine("Es un año bisiesto.");
            }
            else
            {
                Console.WriteLine("NO es un año bisiesto.");
            }
        }

        // Ejercicio 18: Descuento del 10% en compras mayores a 100$
        public static void Ejercicio18()
        {
            Console.Write("Ingrese el monto de la compra: ");
            double monto = double.Parse(Console.ReadLine());

            if (monto > 100)
            {
                double descuento = monto * 0.10;
                double totalPagar = monto - descuento;
                Console.WriteLine("Descuento del 10% aplicado. Total a pagar: $" + totalPagar);
            }
            else
            {
                Console.WriteLine("Total a pagar (sin descuento): $" + monto);
            }
        }

        // Ejercicio 19: Divisibilidad exacta
        public static void Ejercicio19()
        {
            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 != 0 && n1 % n2 == 0)
            {
                Console.WriteLine(n1 + " es divisible exactamente entre " + n2);
            }
            else
            {
                Console.WriteLine(n1 + " NO es divisible exactamente entre " + n2);
            }
        }

        // Ejercicio 20: Horas trabajadas y horas extra
        public static void Ejercicio20()
        {
            Console.Write("Ingrese las horas trabajadas en la semana: ");
            double horas = double.Parse(Console.ReadLine());

            if (horas > 40)
            {
                Console.WriteLine("Tiene horas extra.");
            }
            else
            {
                Console.WriteLine("Jornada normal.");
            }
        }
    }
}