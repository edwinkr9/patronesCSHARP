using Adapter;
using patronesCSHARP;
using patronesCSHARP.Builder.Clases;
using patronesCSHARP.Builder.Entidades;
using System;
using System.Collections.Generic;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart = string.Empty;
            do
            {
                int option;
                Console.Clear();
                Console.WriteLine("================= P R A C T I C A 1 =============================");
                Console.WriteLine("======================== M E N Ú ================================");
                Console.WriteLine("========== 1.- Creacion-Builder     Carlos Be            ========");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("========== 2.- Estructura-Adapter  Edwin Koh             ========");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("========== 3.- Comportamiento-State   Luis Martin         =======");
                Console.Write("========= O P C I Ó N : ");
                option = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (option)
                {
                    case 1: //Builder
                        {
                            int numeroDeCancion = 1;

                            //MATERIAL DISCOGRAFICO
                            String nombre;
                            Double precio;
                            int stock;

                            //AUTOR
                            Autor autor;
                            String nombreArtista;
                            String descripcionArtista;

                            //GENERO
                            Genero genero;
                            String descripcionGenero;

                            //TIPO MATERIAL DISCOGRAFICO
                            TipoMaterialDiscografico tipoMaterialDiscografico;
                            String nombreMaterialDiscografico;

                            //CANCIONES
                            List<Cancion> canciones = new List<Cancion>();
                            Cancion cancion;
                            String nombreCancion;
                            int duracionSegundos;

                            char respuesta;

                            //MATERIAL DISCOGRAFICO
                            Console.Write("Ingrese el nombre del nuevo material: ");
                            nombre = Console.ReadLine();
                            Console.Write("Ingrese el precio del nuevo material: ");
                            precio = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese el stock del nuevo material: ");
                            stock = Convert.ToInt32(Console.ReadLine());

                            //AUTOR
                            Console.Write("Ingrese el nombre del artista: ");
                            nombreArtista = Console.ReadLine();
                            Console.Write("Ingrese descripcion del artista: ");
                            descripcionArtista = Console.ReadLine();
                            autor = new Autor(nombreArtista, descripcionArtista);

                            //GENERO
                            Console.Write("Ingrese el nombre del género: ");
                            descripcionGenero = Console.ReadLine();
                            genero = new Genero(descripcionGenero);

                            //TIPO MATERIAL DISCOGRAFICO
                            Console.Write("Ingrese el nombre del tipo de material discografico: ");
                            nombreMaterialDiscografico = Console.ReadLine();
                            tipoMaterialDiscografico = new TipoMaterialDiscografico(nombreMaterialDiscografico);

                            do
                            {
                                //CANCIONES
                                Console.WriteLine("\nCancion " + numeroDeCancion.ToString());
                                Console.Write("Ingrese el nombre de la canción: ");
                                nombreCancion = Console.ReadLine();
                                Console.Write("Ingrese la duracion de la cancion en segundos: ");
                                duracionSegundos = Convert.ToInt32(Console.ReadLine());

                                cancion = new Cancion(nombreCancion, duracionSegundos);
                                canciones.Add(cancion);

                                numeroDeCancion++;

                                Console.Write("Desea seguir agregando canciones? (S/N): ");
                                respuesta = Console.ReadKey().KeyChar;
                                Console.ReadKey();

                            } while (respuesta == 'S');

                            Console.Clear();

                            //BUILDER MATERIAL DISCOGRAFICO
                            MaterialDiscograficoBuilder builderMaterialDiscografico = new MaterialDiscograficoBuilder();
                            MaterialDiscografico materialDiscografico = builderMaterialDiscografico
                                .ConNombre(nombre)
                                .TienePrecio(precio)
                                .EnStock(stock)
                                .ComoAutor(autor)
                                .ComoCanciones(canciones)
                                .ComoGenero(genero)
                                .ComoTipoMaterialDiscografico(tipoMaterialDiscografico)
                                .BuildMaterialDiscografico();

                            //REPORTAR
                            Console.Write(materialDiscografico.reportarDatos());

                            Console.ReadKey();
                        }
                        break;
                    case 2: //Adapter
                        Motor motor1 = new MotorNaftero();
                        motor1.Arrancar();
                        motor1.Acelerar();
                        motor1.Detener();
                        motor1.CargarCombustible();


                        Motor motor2 = new MotorDiesel();
                        motor2.Arrancar();
                        motor2.Acelerar();
                        motor2.Detener();
                        motor2.CargarCombustible();


                        Motor motor3 = new MotorElectricoAdapter();
                        motor3.Arrancar();
                        motor3.Acelerar();
                        motor3.Detener();
                        motor3.CargarCombustible();

                        Console.ReadKey();
                        break;

                    case 3: //State
                        //Let's cook a steak!
                        Filete account = new Filete("T-Bone");
                        account.AddTemp(120);

                        string cook = string.Empty;
                        do
                        {
                            Console.Write("¡Aumentar temperatura (+) o Disminuir temperatura (-)?: ");
                            switch (Console.ReadLine())
                            {
                                case "+":
                                    Console.Write("Aumentar: ");
                                    account.AddTemp(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                case "-":
                                    Console.Write("Disminuir: ");
                                    account.RemoveTemp(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                default:
                                    Console.Write("No Valido\n");
                                    break;
                            }

                            Console.Write("¿Seguir cocinando? (s): ");
                            cook = Console.ReadLine();
                        } while (cook == "s" || cook == "S");

                        break;


                }

                Console.WriteLine("¿Volver al menu? (s/n)");
                restart = Console.ReadLine();
            }
            while (restart == "s" || restart == "S");
        }
    }
}
