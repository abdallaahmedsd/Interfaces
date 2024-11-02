
namespace CustomInterfaces;

// The pointy behavior as a read-only property.
public interface IPointy
{
	// Implicitly public and abstract.
	//byte GetNumberOfPoints();

	// A read-write property in an interface would look like:
	//string PropName { get; set; }

	// while a read-only property in an interface would be:
	byte Points { get; }
}
