using AplicacionReal;
using System;

namespace AplicacionProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IRepository repo = new CustomerRepositoryProxy();

                Session.CanSave = true;
                Session.CanGetAll = true;

                Console.WriteLine($"Sistema para agregar empleados");
                Console.WriteLine("Primer empleado:");
                Customer p1 = new Customer(Console.ReadLine());
                Console.WriteLine("Segundo empleado:");
                Customer p2 = new Customer(Console.ReadLine());

                repo.Save(p1);
                repo.Save(p2);

                Console.WriteLine("Empleados agregados correctamente:");
                foreach (var p in repo.GetAll())
                {
                    Console.WriteLine($"{p.Name}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
