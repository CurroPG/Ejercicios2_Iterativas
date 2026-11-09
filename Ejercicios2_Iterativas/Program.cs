using System;
using System.Collections;

namespace Ejercicios2_Iterativas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio9();
            Ejercicio10();
            Ejercicio11();

            Console.ReadKey();
        }

        // 1. Mayor de dos números en un solo WriteLine y sin concatenar
        static void Ejercicio1()
        {
            Console.WriteLine("\n--- Ejercicio 1 ---");
            Console.WriteLine("Introduce el primer número:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a == b ? "Los dos números son iguales: {0}" : "El mayor es {0}", Math.Max(a, b));
        }

        // 2. Factura de la luz según los kilowatios consumidos
        static void Ejercicio2()
        {
            Console.WriteLine("\n--- Ejercicio 2 ---");
            Console.WriteLine("Introduce los kilowatios consumidos:");
            double kw = Convert.ToDouble(Console.ReadLine());

            double precio;
            if (kw > 1800)
            {
                precio = 0.8;
            }
            else if (kw >= 1000)
            {
                precio = 0.12;
            }
            else
            {
                precio = 0.14;
            }

            double total = kw * precio;
            Console.WriteLine($"Total a pagar: {total:C2}");
        }

        // 3. Estado civil con switch
        static void Ejercicio3()
        {
            Console.WriteLine("\n--- Ejercicio 3 ---");
            Console.WriteLine("Introduce tu estado civil abreviado (C, S, V o D):");
            string estado = Console.ReadLine().ToUpper();

            switch (estado)
            {
                case "C":
                    Console.WriteLine("Tu estado civil es Casad@");
                    break;
                case "S":
                    Console.WriteLine("Tu estado civil es Solter@");
                    break;
                case "V":
                    Console.WriteLine("Tu estado civil es Viud@");
                    break;
                case "D":
                    Console.WriteLine("Tu estado civil es Divorciad@");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Debes introducir C, S, V o D.");
                    break;
            }
        }

        // 4. Tabla de multiplicar de un número del 1 al 9
        static void Ejercicio4()
        {
            Console.WriteLine("\n--- Ejercicio 4 ---");
            int numero;
            do
            {
                Console.WriteLine("Introduce un número del 1 al 9:");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 1 || numero > 9)
                {
                    Console.WriteLine("Número fuera de rango, prueba otra vez.");
                }
            } while (numero < 1 || numero > 9);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        // 5. Operaciones con strings
        static void Ejercicio5()
        {
            Console.WriteLine("\n--- Ejercicio 5 ---");
            Console.WriteLine("Introduce una cadena de texto:");
            string texto = Console.ReadLine();
            Console.WriteLine("Introduce una subcadena para buscarla dentro del texto:");
            string subcadena = Console.ReadLine();

            Console.WriteLine($"Longitud: {texto.Length}");
            Console.WriteLine($"¿Contiene \"{subcadena}\"?: {texto.Contains(subcadena)}");
            Console.WriteLine($"Reemplazando la 'a' por la 'e': {texto.Replace('a', 'e')}");
            Console.WriteLine($"En mayúsculas: {texto.ToUpper()}");
            Console.WriteLine($"En minúsculas: {texto.ToLower()}");

            if (texto.Length > 0)
            {
                Console.WriteLine($"Eliminando el carácter de la posición 0: {texto.Remove(0, 1)}");
            }

            // Substring recibe la posición de inicio y la longitud, por eso la longitud es fin - inicio
            int inicio = 1;
            int fin = 4;
            if (texto.Length >= fin)
            {
                Console.WriteLine($"Subcadena de la posición {inicio} a la {fin}: {texto.Substring(inicio, fin - inicio)}");
            }
        }

        // 6. Factorial con un bucle
        static void Ejercicio6()
        {
            Console.WriteLine("\n--- Ejercicio 6 ---");
            Console.WriteLine("Introduce un número:");
            int n = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;
            for (int i = n; i > 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {n} es {factorial}");
        }

        // 7. Abecedario de la Z a la A usando los códigos ASCII
        static void Ejercicio7()
        {
            Console.WriteLine("\n--- Ejercicio 7 ---");
            for (int i = 90; i >= 65; i--)
            {
                Console.Write(Convert.ToString(Convert.ToChar(i)) + " ");
            }
            Console.WriteLine();
        }

        // 8. Número aleatorio entre 10 y 30
        static void Ejercicio8()
        {
            Console.WriteLine("\n--- Ejercicio 8 ---");
            Random random = new Random();
            // El segundo número de Next no se incluye, por eso es 31
            int aleatorio = random.Next(10, 31);

            Console.WriteLine($"Número aleatorio: {aleatorio}");
        }

        // 9. Array del tamaño que diga el usuario, mostrando pares e impares
        static void Ejercicio9()
        {
            Console.WriteLine("\n--- Ejercicio 9 ---");
            Console.WriteLine("¿De qué tamaño quieres el array?");
            int tamano = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[tamano];

            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine($"Introduce el valor de la posición {i}:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Pares: ");
            foreach (int n in numeros)
            {
                if (n % 2 == 0)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();

            Console.Write("Impares: ");
            foreach (int n in numeros)
            {
                if (n % 2 != 0)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
        }

        // 10. Ordenar un array con Array.Sort y recorrerlo con un for
        static void Ejercicio10()
        {
            Console.WriteLine("\n--- Ejercicio 10 ---");
            int[] numeros = { 42, 7, 19, 3, 88, 25, 61, 14, 70, 1 };

            Array.Sort(numeros);

            Console.Write("Array ordenado: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine();
        }

        // 11. Pila con System.Collections.Stack
        static void Ejercicio11()
        {
            Console.WriteLine("\n--- Ejercicio 11 ---");
            Stack pila = new Stack();

            Console.WriteLine("¿Cuántos valores quieres meter en la pila?");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Introduce el valor {i + 1}:");
                pila.Push(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Write("Contenido de la pila: ");
            MostrarPila(pila);

            if (pila.Count >= 2)
            {
                Console.WriteLine($"Saco de la pila el {pila.Pop()}");
                Console.WriteLine($"Saco de la pila el {pila.Pop()}");

                Console.Write("Contenido de la pila después de sacar dos: ");
                MostrarPila(pila);
            }
            else
            {
                Console.WriteLine("La pila necesita al menos dos valores para poder sacar dos.");
            }
        }

        // Función auxiliar del ejercicio 11: muestra la pila empezando por la cima
        static void MostrarPila(Stack pila)
        {
            foreach (object valor in pila)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
        }
    }
}