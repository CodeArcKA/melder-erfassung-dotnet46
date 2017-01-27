using System;
using System.Collections.Generic;

namespace MelderErfassung.ReadModels
{
    public class AuftragsReadModel
    {
        public static List<Auftrag> Aufträge = new List<Auftrag>();

        public static void Print()
        {
            Console.WriteLine("Aufträge: ");
            foreach (var auftrag in Aufträge)
            {
                Console.WriteLine("\t" + auftrag);
            }
        }
    }
}