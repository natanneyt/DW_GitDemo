using Domein;
using System;
using System.Collections.Generic;

namespace Container_Oef.Cui
{
	public class ContainerApplicatie
	{
		public static void Main(string[] args)
		{
			List<Container> containers = new List<Container>();

			containers.Add(new Container("Antwerpen", 60, 150, 1234));
			containers.Add(new Container("Rotterdam", 70, 110, 2568));
			containers.Add(new Container("Calais", 80, 90, 8569));
			containers.Add(new Container("Brugge", 70, 100, 8564));

			Container nieuweContainer = new Container("Antwerpen", 70, 75, 8564);

			// Kijk na of de nieuwe container reeds in de lijst aanwezig is en
			// druk het resultaat af op het scherm.
			Console.WriteLine("\nGesorteerd op volume:");

			containers.Sort();
            foreach (Container container in containers) Console.WriteLine(container);

			Console.WriteLine("\nGesorteerd op massa:");
            containers.Sort(new SorteerOpMassaComparer());
            foreach (Container container in containers) Console.WriteLine(container);


            Console.WriteLine("\nGesorteerd op eigenaar:");
            containers.Sort(new SorteerOpEigenaarComparer());
            foreach (Container container in containers) Console.WriteLine(container);
        }
    }
}