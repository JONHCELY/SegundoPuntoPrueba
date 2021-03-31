using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaPunto2
{
    public class prueba
    {
        List<int> listaElementos = new List<int>();
        int num, num2, menor, mayor, buscar, agregar;
        string nuevaAccion;

        public void IngresarDatos()
        {
            Console.WriteLine("Por Favor ingrese la cantidad de elementos que desea almacenar");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Por Favor ingrese su lista de datos");
            for (int i = 0; i < num; i++)
            {
                num2 = int.Parse(Console.ReadLine());
                listaElementos.Add(num2);
            }            
            mostrarDatos();
        }

        public void mostrarDatos() {
            Console.WriteLine();
            Console.WriteLine("Lista de Datos ingresados: ");
            Console.WriteLine();
            foreach (var item in listaElementos)
            {
                Console.WriteLine(item);
            }
        }

        public void Accion()
        {
            Console.WriteLine();
            int accion;
            Console.WriteLine("Por favor escoja el número de la acción que desea realizar: ");
            Console.WriteLine();
            Console.WriteLine("1 - Ordenar los Elementos ingresados de Menor a Mayor");
            Console.WriteLine("2 - Ordenar los Elementos ingresados de Mayor a Menor");            
            Console.WriteLine("3 - Buscar un número dentro de los elementos ingresados");
            Console.WriteLine("4 - Agregar un Elemento a la lista");
            Console.WriteLine("5 - Listar los elementos que se encuntran repetidos dentro de la lista");
            Console.WriteLine();

            accion = int.Parse(Console.ReadLine());
            switch (accion)
            {
                case 1:
                    Menor();
                    break;
                case 2 :
                    Mayor();
                    break;
                case 3:
                    Busqueda();
                    break;
                case 4:
                    Agregar();
                    break;
                case 5:
                    Repetidos();
                    break;                
                default:
                    Console.WriteLine("El numero ingresado no se encuentra en la lista por favor intente de nuevo");
                    Accion();
                    break;
            }
        }

        public void Menor() {

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num - 1 ; j++)
                {
                    if (listaElementos[i] < listaElementos[j])
                    {
                        menor = listaElementos[i];
                        listaElementos[i] = listaElementos[j];
                        listaElementos[j] = menor;
                    }
                }
            }
            
            Console.WriteLine("Numeros de Menor a Mayor");
            Console.WriteLine();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(listaElementos[i]);
            }

            accionNueva();

        }

        public void Mayor()
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num - 1; j++)
                {
                    if (listaElementos[i] > listaElementos[j])
                    {
                        mayor = listaElementos[i];
                        listaElementos[i] = listaElementos[j];
                        listaElementos[j] = mayor;
                    }
                }
            }

            Console.WriteLine("Numeros de Mayor a Menor");
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(listaElementos[i]);
            }

            accionNueva();
        }

        public void Busqueda()
        {
            Console.WriteLine();
            Console.WriteLine("Por favor ingrese el numero que desea buscar en la lista antes digitada");
            buscar = int.Parse(Console.ReadLine());
            bool Encontrado = false;
            Console.WriteLine();

            foreach (var item in listaElementos)
            {
                if (item == buscar)
                {
                    Encontrado = true;
                    Console.WriteLine("El numero: "+ buscar + " se encuentra en la posicion de la lista #: " + item);
                }                
            }
            if (Encontrado == false)
            {
                Console.WriteLine("El numero a buscar no se encuntra en la lista.");
            }
            accionNueva();
        }

        public void Agregar()
        {
            Console.WriteLine("");
            Console.WriteLine("Por favor ingrese el numero que desea agregar a lista ya antes digitada");
            Console.WriteLine("");
            agregar = int.Parse(Console.ReadLine());
            listaElementos.Insert(0, agregar);
            Console.WriteLine("");
            Console.WriteLine("El numero ingresado se vera reflejao al principio de la lista");
            Console.WriteLine("");
            mostrarDatos();
            Console.WriteLine();
            accionNueva();
            listaElementos.Add(agregar);
            num = num + 1;
        }

        public void Repetidos()
        {

            Console.WriteLine("Lista de Numeros Repetidos");
            bool repetidos = false;
            for (int i = 0; i < listaElementos.Count; i++)
            {
                int a = listaElementos[i];
                int cont = i + 1;
                for (int j = cont; j < listaElementos.Count; j++)
                {
                    int b = listaElementos[j];
                    if (a == b )
                    {
                        repetidos = true;
                        Console.WriteLine("Se repite el número: " + a );
                    }
                }
            }
            if (repetidos==false)
            {
                Console.WriteLine("No hay numeros repetidos");
            }

            accionNueva();
        }

        public void accionNueva() {
            Console.WriteLine("");
            Console.WriteLine("Desea realizar alguna otra Accion S / N ");
            nuevaAccion = Console.ReadLine();
            Console.WriteLine("");
            switch (nuevaAccion)
            {
                case "s":
                    Accion();
                    break;
                default:
                    Console.WriteLine("Gracias por su tiempo");
                    break;
            }

        }
    }
}
