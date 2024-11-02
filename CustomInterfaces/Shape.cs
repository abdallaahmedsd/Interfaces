
namespace CustomInterfaces;

abstract class Shape
{
	protected Shape(string name = "NoName")
	{
		PetName = name;
	}
	public string PetName { get; set; }
	// A single virtual method.
	public abstract void Draw();
}
