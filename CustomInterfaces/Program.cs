using CustomInterfaces;
using System.Reflection.Metadata;

Console.WriteLine("***** Fun with Interfaces *****\n");
//// Call Points property defined by IPointy.
//Hexagon hex = new Hexagon();
//Console.WriteLine("Points: {0}", hex.Points);

//// Can we treat hex2 as IPointy?
//Hexagon hex2 = new Hexagon("Peter");
//IPointy itfPt2 = hex2 as IPointy;

//if (itfPt2 != null)
//{
//	Console.WriteLine("Points: {0}", itfPt2.Points);
//}
//else
//{
//	Console.WriteLine("OOPS! Not pointy...");
//}

//if (hex2 is IPointy itfPt3)
//{
//	Console.WriteLine("Points: {0}", itfPt3.Points);
//}
//else
//{
//	Console.WriteLine("OOPS! Not pointy...");
//}

//var sq = new Square("Boxy")
//{ NumberOfSides = 4, SideLength = 4 };
//sq.Draw();
////This won't compile
////Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of { sq.Perimeter }");
//Console.WriteLine(
//	$"{sq.PetName} has" +
//	$" {sq.NumberOfSides} of length" +
//	$" {sq.SideLength} and a perimeter of " +
//	$"{ ((IRegularPointy)sq).Perimeter}"
//	);

//Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");
//IRegularPointy.ExampleProperty = "Updated";
//Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");

//Shape[] myShapes = {
//	new Hexagon(),
//	new Circle(),
//	new Triangle("Joe"),
//	new Circle("JoJo")
//};

//for (int i = 0; i < myShapes.Length; i++)
//{
//	// Can I draw you in 3D?
//	if (myShapes[i] is IDraw3D s)
//	{
//		DrawIn3D(s);
//	}
//}

//// Get first pointy item.
//IPointy firstPointyItem = FindFirstPointyShape(myShapes);
//// To be safe, use the null conditional operator.
//Console.WriteLine("The item has {0} points",
//firstPointyItem?.Points);


// This array can only contain types that
// implement the IPointy interface.
IPointy[] myPointyObjects =
{
	new Hexagon(),
	new Knife(),
	new Triangle(),
	new Fork(),
	new PitchFork()
};
foreach (IPointy i in myPointyObjects)
{
	Console.WriteLine("Object has {0} points.", i.Points);
}

Console.ReadLine();

// I'll draw anyone supporting IDraw3D.
static void DrawIn3D(IDraw3D itf3d)
{
	Console.WriteLine("-> Drawing IDraw3D compatible type");
	itf3d.Draw3D();
}

// This method returns the first object in the
// array that implements IPointy.
static IPointy FindFirstPointyShape(Shape[] shapes)
{
	foreach (Shape s in shapes)
	{
		if (s is IPointy ip)
		{
			return ip;
		}
	}
	return null;
}