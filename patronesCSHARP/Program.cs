using patronesCSHARP.AF.Clases;
using patronesCSHARP.Builder.Clases;
using patronesCSHARP.Builder.Entidades;
using patronesCSHARP.Composite;
using patronesCSHARP.Decorator;
using System;
using System.Collections.Generic;
using patronesCSHARP.Iterator;
using patronesCSHARP.Strategy;
using static patronesCSHARP.Visitor;
using patronesCSHARP.Adapter;
using patronesCSHARP.Singleton;
using patronesCSHARP.Factory_Method;
using patronesCSHARP.Bridge;
using patronesCSHARP.Command;
using patronesCSHARP.Chain_of_Responsability;

namespace patronesCSHARP
{
    public class Program
    {
        static void Main(string[] args)
        {
            string restart = string.Empty;
            do
            {
                int option;
                Console.Clear();
                Console.WriteLine("====================== M E N Ú ========================");
                Console.WriteLine("========== 1.- Creacion-Singleton      Edwin Koh         ========");
                Console.WriteLine("========== 2.- Creacion-Factory Method Edwin Koh         ========");
                Console.WriteLine("========== 3.- Creacion-Builder     Carlos Be            ========");
                Console.WriteLine("========== 4.- Creacion-Abstract Factory  Carlos Be      ========");
                Console.WriteLine("========== 5.- Creacion-Prototype    Luis Martin         ========");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("========== 6.- Estructura-Bridge   Edwin Koh             ========");
                Console.WriteLine("========== 7.- Estructura-Adapter  Edwin Koh             ========");
                Console.WriteLine("========== 8.- Estructura-Composite  Carlos Be           ========");
                Console.WriteLine("========== 9.- Estructura-Decorator   Carlos Be          ========");
                Console.WriteLine("========== 10.- Estructura-Facade    Luis Martin         ========");
                Console.WriteLine("========== 11.- Estructura-Flyweight Luis Martin         ========");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("========== 12.- Comportamiento-Command   Edwin Koh       ========");
                Console.WriteLine("========== 13.- Comportamiento-Chain of responsibilty Edwin Koh =");
                Console.WriteLine("========== 14.- Comportamiento-Iterator Carlos Be        ========");
                Console.WriteLine("========== 15.- Comportamiento-Strategy   Carlos Be      ========");
                Console.WriteLine("========== 16.- Comportamiento-Visitor  Luis Martin       =======");
                Console.WriteLine("========== 17.- Comportamiento-Template Method Luis Martin ======");
                Console.WriteLine("========== 18.- Comportamiento-State   Luis Martin        =======");
                Console.WriteLine("========== 19.- Comportamiento-Memento   Luis Martin      =======");
                Console.Write("========= O P C I Ó N : ");
                option = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (option)
                {
                    case 1: //Singleton --------------------------------------------------------------------------------------
                        Usuario usuario = new Usuario();
                        usuario.Username = "Prueba";
                        usuario.Password = "Prueba";
                        try
                        {
                            Manager.Login(usuario);
                            Manager u = Manager.GetInstance;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 2: //Factory Method --------------------------------------------------------------------------------------
                        Heladeria heladeria;
                        Helado helado;

                        heladeria = new HeladeriaNorte();
                        helado = heladeria.CrearHelado("Chocolate");
                        helado.Render();
                        helado = heladeria.CrearHelado("Vainilla");
                        helado.Render();

                        heladeria = new HeladeriaSur();
                        helado = heladeria.CrearHelado("Chocolate");
                        helado.Render();
                        helado = heladeria.CrearHelado("Vainilla");
                        helado.Render();
                        Console.ReadKey();
                        break;

                    case 3: //Builder --------------------------------------------------------------------------------------
                        {
                            int numeroDeCancion = 1;

                            // MATERIAL DISCOGRAFICO
                            String nombre;
                            Double precio;
                            int stock;

                            // AUTOR
                            Autor autor;
                            String nombreArtista;
                            String descripcionArtista;

                            // GENERO
                            Genero genero;
                            String descripcionGenero;

                            // TIPO MATERIAL DISCOGRAFICO
                            TipoMaterialDiscografico tipoMaterialDiscografico;
                            String nombreMaterialDiscografico;

                            // CANCIONES
                            List<Cancion> canciones = new List<Cancion>();
                            Cancion cancion;
                            String nombreCancion;
                            int duracionSegundos;

                            char respuesta;

                            // MATERIAL DISCOGRAFICO
                            Console.Write("Ingrese el nombre del nuevo material: ");
                            nombre = Console.ReadLine();
                            Console.Write("Ingrese el precio del nuevo material: ");
                            precio = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese el stock del nuevo material: ");
                            stock = Convert.ToInt32(Console.ReadLine());

                            // AUTOR
                            Console.Write("Ingrese el nombre del artista: ");
                            nombreArtista = Console.ReadLine();
                            Console.Write("Ingrese descripcion del artista: ");
                            descripcionArtista = Console.ReadLine();
                            autor = new Autor(nombreArtista, descripcionArtista);

                            // GENERO
                            Console.Write("Ingrese el nombre del género: ");
                            descripcionGenero = Console.ReadLine();
                            genero = new Genero(descripcionGenero);

                            // TIPO MATERIAL DISCOGRAFICO
                            Console.Write("Ingrese el nombre del tipo de material discografico: ");
                            nombreMaterialDiscografico = Console.ReadLine();
                            tipoMaterialDiscografico = new TipoMaterialDiscografico(nombreMaterialDiscografico);

                            do
                            {
                                // CANCIONES
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

                            // BUILDER MATERIAL DISCOGRAFICO
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

                            // REPORTAR
                            Console.Write(materialDiscografico.reportarDatos());

                            Console.ReadKey();
                        }
                        break;

                    case 4: //Abstrac Factory --------------------------------------------------------------------------------------
                        Pizzeria fabrica;

                        fabrica = new PizzeriaDominos();
                        Pizza pizza = fabrica.CrearPizza();
                        Console.WriteLine($"Pizzería: {pizza.Nombre} crea {pizza.Descripcion}");

                        fabrica = new PizzeriaValeros();
                        pizza = fabrica.CrearPizza();
                        Console.WriteLine($"Pizzería: {pizza.Nombre} crea {pizza.Descripcion}");

                        Console.ReadKey();
                        break;

                    case 5://Prototype --------------------------------------------------------------------------------------
                        MethodPrototype();
                        break;

                    case 6: //Bridge --------------------------------------------------------------------------------------
                        SonyControlRemoto sonyRemoteControl = new SonyControlRemoto(new SonyLedTv());
                        sonyRemoteControl.Encender();
                        sonyRemoteControl.EscogerCanal(101);
                        sonyRemoteControl.Apagar();

                        Console.WriteLine();

                        SamsungControlRemoto samsungRemoteControl = new SamsungControlRemoto(new SamsungLedTv());
                        samsungRemoteControl.Encender();
                        samsungRemoteControl.EscogerCanal(202);
                        samsungRemoteControl.Apagar();

                        Console.ReadKey();
                        break;

                    case 7: //Adapter --------------------------------------------------------------------------------------
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
                        
                    case 8: //Composite --------------------------------------------------------------------------------------
                        Componente root = new Directorio("raiz");

                        Componente archivo1 = new Archivo("archivo1.txt", 10);
                        Componente archivo2 = new Archivo("archivo2.txt", 30);
                        Componente archivo3 = new Archivo("archivo3.txt", 120);



                        Componente dir1 = new Directorio("dir1");
                        Componente dir2 = new Directorio("dir2");
                        Componente dir3 = new Directorio("dir3");

                        dir1.AgregarHijo(archivo1);
                        dir2.AgregarHijo(archivo2);
                        dir3.AgregarHijo(archivo3);

                        root.AgregarHijo(dir1);
                        root.AgregarHijo(dir2);
                        root.AgregarHijo(dir3);

                        Console.WriteLine($"El tamaño del directorio {root.Nombre} es {root.ObtenerTamaño}");
                        Console.WriteLine($"El tamaño del directorio {dir1.Nombre} es {dir1.ObtenerTamaño}");
                        Console.WriteLine($"El tamaño del directorio {dir2.Nombre} es {dir2.ObtenerTamaño}");
                        Console.WriteLine($"El tamaño del directorio {dir3.Nombre} es {dir3.ObtenerTamaño}");
                        break;

                    case 9: //Decorator --------------------------------------------------------------------------------------
                        Console.WriteLine("** Cafeteria Develoteca ***");
                        Console.WriteLine("** Su orden ***");
                        BebidaComponent cafe = new CafeDescafeinado();
                        cafe = new Crema(cafe);
                        cafe = new Canela(cafe);

                        Console.WriteLine($"Producto:  {cafe.Descripcion} tiene un costo de : ${cafe.Costo}");

                        cafe = new CafeExpresso();
                        cafe = new Leche(cafe);
                        cafe = new Canela(cafe);

                        Console.WriteLine($"Producto:  {cafe.Descripcion} tiene un costo de : ${cafe.Costo}");

                        Console.ReadKey();
                        break;
                    case 10: //Facade
                        FacadeSystem cajero_automatico = new FacadeSystem();
                        cajero_automatico.introducirCredenciales();
                        cajero_automatico.sacarDinero();
                        break;

                    case 11: //Flyweight --------------------------------------------------------------------------------------
                        var factory = new FlyweightFactory(
                            new Car { compañia = "Chevrolet", modelo = "Camaro2018", color = "pink" },
                            new Car { compañia = "Mercedes Benz", modelo = "C300", color = "black" },
                            new Car { compañia = "Mercedes Benz", modelo = "C500", color = "red" },
                            new Car { compañia = "BMW", modelo = "M5", color = "red" },
                            new Car { compañia = "BMW", modelo = "X6", color = "white" }
                        );
                        factory.listFlyweights();

                        addCarToPoliceDatabase(factory, new Car
                        {
                            number = "TLS01EM",
                            dueño = "Elon Musk",
                            compañia = "Tesla",
                            modelo = "modelo S",
                            color = "White"
                        });

                        Console.Write("\n¿Desea Agregar Manualmente?: (s)");
                        string cont = Console.ReadLine();
                        if (cont == "s" || cont == "S")
                        {
                            var carro = new Car();
                            Console.Write("\nPlacas: ");
                            carro.number = Console.ReadLine();
                            Console.Write("Dueños: ");
                            carro.dueño = Console.ReadLine();
                            Console.Write("Compañia: ");
                            carro.compañia = Console.ReadLine();
                            Console.Write("Modelo: ");
                            carro.modelo = Console.ReadLine();
                            Console.Write("color: ");
                            carro.color = Console.ReadLine();

                            addCarToPoliceDatabase(factory, carro);
                        }
                        else Console.WriteLine("\nRespuesta NO valida\nContinuando Con El Proceso Habitual...");

                        factory.listFlyweights();
                        break;

                    case 12: //Command --------------------------------------------------------------------------------------
                        var empresa = new EmpresaInvoker();
                        var producto = new ProductoReceiver();
                        producto.Cantidad = 100;

                        var ordenAlta = new AltaStock(producto, 10);
                        empresa.TomarOrden(ordenAlta);
                        var ordenBaja = new BajaStock(producto, 50);
                        empresa.TomarOrden(ordenBaja);

                        var ordenBaja2 = new BajaStock(producto, 5);
                        empresa.TomarOrden(ordenBaja2);
                        var ordenBaja3 = new BajaStock(producto, 15);
                        empresa.TomarOrden(ordenBaja3);

                        var ordenAlta2 = new AltaStock(producto, 100);
                        empresa.TomarOrden(ordenAlta2);
                        var ordenAlta3 = new AltaStock(producto, 100);
                        empresa.TomarOrden(ordenAlta3);

                        empresa.ProcesarOrdenes();

                        Console.Write(string.Format("Total stock es {0}", producto.Cantidad));
                        Console.ReadKey();
                        break;

                    case 13: //Chain of responsibilty --------------------------------------------------------------------------------------
                        var comprador = new Comprador();
                        var gerente = new Gerente();
                        var director = new Director();
                        var directorGeneral = new DirectorGeneral();

                        director.AgregarSiguiente(directorGeneral);
                        gerente.AgregarSiguiente(director);
                        comprador.AgregarSiguiente(gerente);

                        var c = new Compra();
                        double importe = 1;
                        while (importe != 0)
                        {
                            Console.WriteLine("Ingrese el importe de la compra");
                            importe = double.Parse(Console.ReadLine());
                            c.Importe = importe;
                            comprador.Procesar(c);
                        }
                        break;
                    case 14: //Iterator --------------------------------------------------------------------------------------
                        Console.WriteLine("Escriba una palabra");
                        var palabra = new Palabra(Console.ReadLine());


                        foreach (var item in palabra)
                        {
                            Console.WriteLine(item);
                        }

                        Console.ReadKey();
                        break;

                    case 15: //Strategy --------------------------------------------------------------------------------------
                        string dato = "";
                        double x = 0;
                        double y = 0;
                        double r = 0;
                        string opcion = "";

                        IOperacion miOperacion = new CSuma();

                        while (opcion != "5")
                        {
                            Console.WriteLine("1-Suma 2-Resta 3-Multiplicacion 4-Divicion 5-Salir");
                            opcion = Console.ReadLine();
                            if (opcion == "5")
                                break;

                            Console.WriteLine("Dame un valor para a");
                            dato = Console.ReadLine();
                            x = Convert.ToDouble(dato);

                            Console.WriteLine("Dame un valor para b");
                            dato = Console.ReadLine();
                            y = Convert.ToDouble(dato);

                            if (opcion == "1")
                                miOperacion = new CSuma();

                            if (opcion == "2")
                                miOperacion = new CResta();

                            if (opcion == "3")
                                miOperacion = new CMulti();

                            if (opcion == "4")
                                miOperacion = new CDiv();

                            r = miOperacion.operacion(x, y);
                            Console.WriteLine("El resultado es {0}:", r);

                        }
                        break;

                    case 16: //Visitor --------------------------------------------------------------------------------------
                        List<Visitor.IComponent> components = new List<Visitor.IComponent>
                        {
                            new ConcreteComponentA(),
                            new ConcreteComponentB()
                        };

                        Console.WriteLine("El código de cliente funciona con todos los visitantes a través de la interfaz de visitante base:");
                        Client.ClientCode(components, new ConcreteVisitor1());

                        Console.WriteLine();

                        Console.WriteLine("Permite que el mismo código de cliente funcione con diferentes tipos de visitantes:");
                        var visitor2 = new ConcreteVisitor2();
                        Client.ClientCode(components, new ConcreteVisitor2());
                        break;

                    case 17: //Template Method --------------------------------------------------------------------------------------
                        Console.Write("Proporcione 1ra medida: ");
                        double medida = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("El mismo código de cliente puede funcionar con diferentes subclases:");
                        ClientTM.ClientCode(new ConcreteClassSquare(), medida);
                        Console.WriteLine("\nEl mismo código de cliente puede funcionar con diferentes subclases:");
                        ClientTM.ClientCode(new ConcreteClassCircle(), medida);
                        break;

                    case 18: //State --------------------------------------------------------------------------------------
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

                    case 19: //Memento --------------------------------------------------------------------------------------
                        Console.WriteLine("========= Lista De Frutas =========");
                        Originator originator = new Originator("Durazno");
                        Caretaker caretaker = new Caretaker(originator);

                        caretaker.Backup();
                        originator.DoSomething();

                        caretaker.Backup();
                        originator.DoSomething();

                        caretaker.Backup();
                        Console.WriteLine();
                        caretaker.ShowHistory();

                        Console.WriteLine("\nRetroceder\n");
                        caretaker.Undo();

                        Console.WriteLine("\n\nRetroceder\n");
                        caretaker.Undo();

                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Opcion NO valida");
                        break;
                }
                Console.WriteLine("¿Volver al menu? (s/n)");
                restart = Console.ReadLine();
            }
            while (restart == "s" || restart == "S");
        }


        public static void MethodPrototype()
        {
            PrototypePerson persona1 = new PrototypePerson();

            #region Peticion 1
            Console.WriteLine("============================ DATOS PREDEFINIDOS ============================");
            Console.WriteLine("Edad: 18");
            Console.WriteLine("Nacimiento [yyyy/mm/dd]: 2001/12/13");
            Console.WriteLine("Nombre: Luis A. Martin Dzul");
            Console.WriteLine("ID: 01");

            persona1.edad = 18;
            persona1.nacimiento = Convert.ToDateTime("2001/12/13");
            persona1.nombre = "Luis A. Martin Dzul";
            persona1.idInf = new PrototypePerson.IdInfo(Convert.ToInt32(12));

            Console.WriteLine("========================== FIN DATOS PREDEFINIDOS ==========================\n");
            #endregion

            PrototypePerson p2 = persona1.ShallowCopy();
            PrototypePerson p3 = persona1.DeepCopy();

            #region Mensaje 1
            // Display values of persona1, p2 and p3.
            Console.WriteLine("\tPersona 1 valor de instancia - Original");
            DisplayValues(persona1);

            Console.WriteLine("\tPersona 2 valor de instancia - Copia Superficial");
            DisplayValues(p2);

            Console.WriteLine("\tPersona 3 valor de instancia - Copia Profunda");
            DisplayValues(p3);

            #endregion

            #region Peticion 2
            Console.WriteLine("============================ INICIO NUEVOS DATOS ============================");
            Console.Write("Edad: ");
            persona1.edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nacimiento [yyyy/mm/dd]: ");
            persona1.nacimiento = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Nombre: ");
            persona1.nombre = Console.ReadLine();

            Console.Write("Contacto: ");
            persona1.idInf.idNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("============================ FIN NUEVOS DATOS ============================\n");
            #endregion

            #region Mensaje 2
            Console.WriteLine("\nValores de persona1, p2 y p3 después de cambios en persona1:");
            Console.WriteLine("   persona1 instance values: ");
            DisplayValues(persona1);
            Console.WriteLine("\tValores de instancia p2 (los valores de referencia han cambiado):");
            DisplayValues(p2);
            Console.WriteLine("\tValores de instancia p3 (todo se mantuvo igual):");
            DisplayValues(p3);

            #endregion

        }
        public static void DisplayValues(PrototypePerson p)
        {
            Console.WriteLine("\tNombre: {0:s}, Edad: {1:d}, Cumpleaños: {2:MM/dd/yy}",
                p.nombre, p.edad, p.nacimiento);
            Console.WriteLine("\tId#: {0:d}", p.idInf.idNumber + "\n");
        }


        public static void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
        {
            Console.WriteLine("\nCliente: Agregan carro nuevo a la base de datos.");

            var flyweight = factory.GetFlyweight(new Car
            {
                color = car.color,
                modelo = car.modelo,
                compañia = car.compañia
            });

            // The client code either stores or calculates extrinsic state and
            // passes it to the flyweight's methods.
            flyweight.Operation(car);
        }
    }
}
