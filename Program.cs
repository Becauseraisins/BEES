using System;
using System.Collections.Generic;
using Bees2.Models;
namespace Bees2
{
    class Program
    {     
            public static List<Bee> Bees= new List<Bee>();
              static void Main(string[] args)
        {   
            Hive h1 = new Hive("First",4);
            h1.Bees.Add(new Bee("John",3.2f));
            h1.Bees.Add(new Bee("paul",2.7f));
            h1.Bees.Add(new Bee("George",1.1f));
            h1.Bees.Add(new Bee("Ringo",2.0f));

            Hive h2 = new Hive("Second",4);
            h2.Bees.Add(new Bee("kurt", 2.3f));
            h2.Bees.Add(new Bee("Dave", 7.4f));
            h2.Bees.Add(new Bee("Krist",1.5f));
            Console.WriteLine(h1.Bees[0].Name);
            Console.WriteLine($"The {h1.Name} hive produces {h1.collecthoney(7)} units of honey per week, while the {h2.Name} produces {h2.collecthoney(7)} units per day");
            if(h1.Capacity==h1.Bees.Count){
                Console.WriteLine($"The {h1.Name} hive is at capacity! (limit {h1.Capacity})");
            }
            else
            {
                Console.WriteLine($"the {h1.Name} hive has {h1.Bees.Count} bees, it can fit {(h1.Capacity)-(h1.Bees.Count)} more" );
            }
            if(h2.Capacity==h2.Bees.Count){
            Console.WriteLine($"The {h2.Name} hive is at capacity! (limit {h2.Capacity})");
            }
            else
            {
            Console.WriteLine($"the {h2.Name} hive has {h2.Bees.Count} bees, it can fit {(h2.Capacity)-(h2.Bees.Count)} more" );
            }
        }
    }
}
