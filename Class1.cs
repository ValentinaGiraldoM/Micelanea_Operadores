using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelanea
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int numero3;
            int resultado = 0;
            int optionMenu;
            int option1;

            int n1, n2;


            Console.WriteLine("\n1.Operadores" + "\n2.Condicionales" + "\n3.Ciclos" + "\n4.Erreglos" + "\n5.Salidas");
            optionMenu = int.Parse(Console.ReadLine());
            Console.WriteLine("\n1.Area de Triangulo" + "\n2.Ingreso de dos numeros y suma entre estos" + "\n3.Numero elevado al cuadrado" + "\n4.Conversión de Euros a Dólares" + "\n5.Valor de área y perímetro segun el lado de un cuadrado" + "\n6.Area y Volumen de un Cilindro" + "\n7.Radio de una circunferencia, longitud y area" + "\n8.Promedio de tres numeros que ingrese");
            option1 = int.Parse(Console.ReadLine());


            switch (optionMenu)
            {
                case 1:
                    switch (option1)
                    {
                        case 1:
                            Console.WriteLine("Por Favor ingresar la base: ");
                            n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Por favor ingresar la altura: ");
                            n2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("El area del triangulo es: " + (n1 * n2) / 2);
                            break;

                        case 2:
                            Console.WriteLine("Por favor ingrese el Primer Numero");
                            n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Por favor ingrese el Segundo Numero");
                            n2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("La suma de estos numeros es: " + (n1 + n2));
                            break;
                        case 3:
                            Console.WriteLine("Por favor ingrese el numero que desea elevar al cuadrado");
                            n1 = int.Parse(Console.ReadLine());
                            double elevadoAlCuadrado = Math.Pow(n1, 2);
                            Console.WriteLine(string.Format("{0} elevado al cuadrado es {1}", n1, elevadoAlCuadrado));
                            break;
                        case 4:
                            Console.WriteLine("Por favor ingrese el valor de dolares que desea pasar a euros (en este momento el euro para esta conversion esta a 1.06 dolares)");
                            n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("El valor es: " + (n1 * 1.06));
                            break;
                        case 5:
                            Console.WriteLine("Ingrese la medida de un lado del cuadro: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El Area es: " + AreaEnteros(numero1));
                            static string AreaEnteros(int n1)
                            {
                                return Convert.ToString(n1 *= n1);
                            }
                            Console.WriteLine("El Perimetro es: " + PerimetroEnteros(numero1));
                            static string PerimetroEnteros(int n1)
                            {
                                return Convert.ToString(n1 + n1 + n1 + n1);
                            }
                            break;
                        case 6:
                            Console.WriteLine("Ingrese el numero de la Altura:  ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese e numero de la Radio: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El area es: " + AreaCEnteros(numero1, numero2));
                            static string AreaCEnteros(int n1, int n2)
                            {
                                return Convert.ToString((2 * 3.14) * n2 * n1 + (2 * 3.14) * (n2 * n2));
                            }
                            Console.WriteLine("El Volumen es: " + VolumenEnteros(numero1, numero2));
                            static string VolumenEnteros(int n1, int n2)
                            {
                                return Convert.ToString(3.14 * (n2 * n2) * n1);
                            }
                            break;
                        case 7:
                            Console.WriteLine("Ingrese el numero del Diametro:  ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El radio es: " + CircunferenciaEnteros(numero1));
                            static string CircunferenciaEnteros(int n1)
                            {
                                return Convert.ToString(n1 / 2);
                            }
                            Console.WriteLine("La longitud es: " + LongitudEnteros(numero1));
                            static string LongitudEnteros(int n1)
                            {
                                return Convert.ToString((2 * 3.14) * n1);
                            }
                            Console.WriteLine("Ingrese el numero del area");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El area es: " + AreaCirEnteros(numero1, numero2));
                            static string AreaCirEnteros(int n1, int n2)
                            {
                                return Convert.ToString(3.14 * (2 * n2));
                            }
                            break;
                        case 8:
                            Console.WriteLine("Ingrese el primer numero:  ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el tercer numero: ");
                            numero3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El Promedio es es: " + PromedioEnteros(numero1, numero2, numero3));
                            static string PromedioEnteros(int n1, int n2, int n3)
                            {
                                return Convert.ToString(n1 + n2 + n3 / 3);
                            }
                            break;

                    }

                    break;
            }
        }
    }
}
