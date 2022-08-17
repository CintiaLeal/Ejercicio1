using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Clases;
using System.Reflection;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            // C A R G A  D E  D A T O S
            Persona x = new Persona();
            x.Nombre = "Cintia";
            x.Apellido = "Leal";
            x.Documento = "54274588";
            DateTime date = new DateTime(2000, 03, 11);
            x.FechaNacimiento = date;

            Persona c = new Persona();
            c.Nombre = "Sol";
            c.Apellido = "Leal";
            c.Documento = "54274588";
            DateTime datec = new DateTime(2006, 04, 11);
            c.FechaNacimiento = datec;


            Persona de = new Persona();
            de.Nombre = "Sage";
            de.Apellido = "Sage";
            de.Documento = "454646747";
            DateTime datede = new DateTime(2003, 11, 20);
            de.FechaNacimiento = datede;

            Persona e = new Persona();
            e.Nombre = "Juan";
            e.Apellido = "Perez";
            e.Documento = "454646747";
            DateTime datee = new DateTime(2002, 12, 09);
            e.FechaNacimiento = datee;


            Persona g = new Persona();
            g.Nombre = "Marco";
            g.Apellido = "Perez";
            g.Documento = "454646747";
            DateTime dateg = new DateTime(2002, 08, 02);
            g.FechaNacimiento = dateg;

            Persona f = new Persona();
            f.Nombre = "Marco";
            f.Apellido = "Perez";
            f.Documento = "454646747";
            DateTime datef = new DateTime(2002, 08, 03);
            f.FechaNacimiento = datef;

            Persona i = new Persona();
            i.Nombre = "Marco";
            i.Apellido = "Perez";
            i.Documento = "454646747";
            DateTime datei = new DateTime(2002, 08, 04);
            i.FechaNacimiento = datei;

            lista.Add(x);
            lista.Add(c);
            lista.Add(i);
            lista.Add(de);
            lista.Add(e);
            lista.Add(g);
            lista.Add(f);
            do
            {
               
                Console.WriteLine("#########################################################");
                Console.WriteLine("###### I N G R E S A R   N U E V A   P E R S O N A ######");
                Console.WriteLine("#########################################################");
              
                try
                {
                    Persona p = new Persona();

                    Console.WriteLine("################# N O M B R E ###########################");
                    p.Nombre = Console.ReadLine();
                    Console.WriteLine("################# A P E L L I D O #######################");
                    p.Apellido = Console.ReadLine();
                    Console.WriteLine("################# D O C U M E N T O #####################");
                    p.Documento = Console.ReadLine();
                    Console.WriteLine("################# F E C H A D E  N A C I M I E N T O ####");
                    Console.WriteLine("################# D I A #################################");
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine("################# M E S #################################");
                    int m = int.Parse(Console.ReadLine());
                    Console.WriteLine("################# A Ñ O #################################");
                    int a = int.Parse(Console.ReadLine());
                    DateTime date1 = new DateTime(a, m, d);
                    p.FechaNacimiento = date1;

                    Console.WriteLine(date1.ToString());        

                    lista.Add(p);


                }
                catch (Exception ex)
                {

                    Console.WriteLine("ERROR: " + ex.Message);
                }
            } while (!Console.ReadLine().Equals("EXIT"));
            {
               
                Console.WriteLine("################# F I N  D E L  P R O G R A M A #################");
                
                List<Persona> lisp = lista.OrderBy(Persona => Persona.FechaNacimiento).ToList();

                foreach (Persona value in lisp)
                {
                    Console.WriteLine("#############################################################");
                    Console.WriteLine("Nombre: " + value.Nombre + " " + value.Apellido);
                    Console.WriteLine("Documento: " + value.Documento);
                    Console.WriteLine("Fecha de Nacimiento: " + value.FechaNacimiento);
                    Console.WriteLine("#############################################################");

                }
                Console.ReadLine();
            };
            
        }
    }
}
