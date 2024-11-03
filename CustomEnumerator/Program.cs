// This seems reasonable ...
using CustomEnumerator;
using System.Collections;

Console.WriteLine("***** Fun with IEnumerable / IEnumerator *****\n");
Garage carLot = new Garage();

// Hand over each car in the collection?
foreach (Car c in carLot)
{
	Console.WriteLine("{0} is going {1} MPH",
	c.PetName, c.CurrentSpeed);
}

// Manually work with IEnumerator.
//IEnumerator carEnumerator = carLot.GetEnumerator();
//carEnumerator.MoveNext();
//Car myCar = (Car)i.Current;
//Console.WriteLine("{0} is going {1} MPH", myCar.PetName, myCar.CurrentSpeed);

Console.ReadLine();