using System;

namespace ggdelta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("   GUÍA PRÁCTICA - PROGRAMACIÓN II      ");
            Console.WriteLine("========================================");
            Console.Write("Ingrese el número de ejercicio a probar (1 al 40): ");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                // Nivel 1 (1 - 10)
                case 1: Nivel1.Ejercicio01(); break;
                case 2: Nivel1.Ejercicio02(); break;
                case 3: Nivel1.Ejercicio03(); break;
                case 4: Nivel1.Ejercicio04(); break;
                case 5: Nivel1.Ejercicio05(); break;
                case 6: Nivel1.Ejercicio06(); break;
                case 7: Nivel1.Ejercicio07(); break;
                case 8: Nivel1.Ejercicio08(); break;
                case 9: Nivel1.Ejercicio09(); break;
                case 10: Nivel1.Ejercicio10(); break;

                // Nivel 2 (11 - 20)
                case 11: Nivel2.Ejercicio11(); break;
                case 12: Nivel2.Ejercicio12(); break;
                case 13: Nivel2.Ejercicio13(); break;
                case 14: Nivel2.Ejercicio14(); break;
                case 15: Nivel2.Ejercicio15(); break;
                case 16: Nivel2.Ejercicio16(); break;
                case 17: Nivel2.Ejercicio17(); break;
                case 18: Nivel2.Ejercicio18(); break;
                case 19: Nivel2.Ejercicio19(); break;
                case 20: Nivel2.Ejercicio20(); break;

                // Nivel 3 (21 - 30)
                case 21: Nivel3.Ejercicio21(); break;
                case 22: Nivel3.Ejercicio22(); break;
                case 23: Nivel3.Ejercicio23(); break;
                case 24: Nivel3.Ejercicio24(); break;
                case 25: Nivel3.Ejercicio25(); break;
                case 26: Nivel3.Ejercicio26(); break;
                case 27: Nivel3.Ejercicio27(); break;
                case 28: Nivel3.Ejercicio28(); break;
                case 29: Nivel3.Ejercicio29(); break;
                case 30: Nivel3.Ejercicio30(); break;

                // Nivel 4 (31 - 40)
                case 31:
                    Console.Write("Ingrese su nombre: ");
                    string nom = Console.ReadLine();
                    Nivel4.Saludar(nom);
                    break;

                case 32:
                    Console.Write("Ingrese un número entero: ");
                    int numPar = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿Es par?: " + Nivel4.EsPar(numPar));
                    break;

                case 33:
                    Console.Write("Primer número: ");
                    double val1 = double.Parse(Console.ReadLine());
                    Console.Write("Segundo número: ");
                    double val2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("El mayor es: " + Nivel4.CalcularMayor(val1, val2));
                    break;

                case 34:
                    Console.Write("Dividendo: ");
                    double d1 = double.Parse(Console.ReadLine());
                    Console.Write("Divisor: ");
                    double d2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado: " + Nivel4.DividirConValidacion(d1, d2));
                    break;

                case 35:
                    var coords = Nivel4.PedirCoordenadas();
                    Console.WriteLine("Coordenadas recibidas -> X: " + coords.x + ", Y: " + coords.y);
                    break;

                case 36:
                    var usuario = Nivel4.ObtenerDatosUsuario();
                    Console.WriteLine("Datos recibidos -> Nombre: " + usuario.Item1 + ", Edad: " + usuario.Item2 + ", Cargo: " + usuario.Item3);
                    break;

                case 37:
                    Console.WriteLine("Probando clase Calculadora:");
                    Console.WriteLine("Suma (10 + 5): " + Calculadora.Sumar(10, 5));
                    Console.WriteLine("Resta (10 - 5): " + Calculadora.Restar(10, 5));
                    Console.WriteLine("Multiplicación (10 * 5): " + Calculadora.Multiplicar(10, 5));
                    Console.WriteLine("División (10 / 5): " + Calculadora.Dividir(10, 5));
                    break;

                case 38:
                    double numSeguro = Nivel4.PedirNumeroSeguro("Ingrese un número (con validación TryParse): ");
                    Console.WriteLine("Número validado correctamente: " + numSeguro);
                    break;

                case 39:
                    Console.Write("Ingrese su salario bruto: ");
                    double sueldoBruto = double.Parse(Console.ReadLine());
                    var liquidacion = Nivel4.CalcularSalario(sueldoBruto);
                    Console.WriteLine("Salario Bruto: $" + liquidacion.SalarioBruto);
                    Console.WriteLine("Descuento Seguro (10%): $" + liquidacion.DescuentoSeguro);
                    Console.WriteLine("Salario Neto a cobrar: $" + liquidacion.SalarioNeto);
                    break;

                case 40:
                    Nivel4.MostrarMenu();
                    break;

                default:
                    Console.WriteLine("Opción no válida (debe ser del 1 al 40).");
                    break;
            }

            Console.WriteLine("\nPresione ENTER para salir...");
            Console.ReadLine();
        }
    }
}