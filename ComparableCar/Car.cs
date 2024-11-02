using System.Collections;

namespace ComparableCar
{
	internal class Car : IComparable
	{

		// Constant for maximum speed.
		public const int MaxSpeed = 100;
		// Car properties.
		public int CurrentSpeed { get; set; } = 0;
		public string PetName { get; set; } = "";
		public int CarID { get; set; }

		// Is the car still operational?
		private bool _carIsDead;

		// A car has-a radio.
		private readonly Radio _theMusicBox = new Radio();
		// Constructors.
		public Car() { }
		public Car(string name, int speed)
		{
			CurrentSpeed = speed;
			PetName = name;
		}
		public Car(string name, int currSp, int id)
		{
			CurrentSpeed = currSp;
			PetName = name;
			CarID = id;
		}
		public void CrankTunes(bool state)
		{
			// Delegate request to inner object.
			_theMusicBox.TurnOn(state);
		}

		// This time, throw an exception if the user speeds up beyond MaxSpeed.
		public void Accelerate(int delta)
		{
			if (_carIsDead)
			{
				Console.WriteLine("{0} is out of order...", PetName);
			}
			else
			{
				CurrentSpeed += delta;
				if (CurrentSpeed >= MaxSpeed)
				{
					CurrentSpeed = 0;
					_carIsDead = true;
					// Use the "throw" keyword to raise an exception and
					// return to the caller.
					throw new Exception($"{PetName} has overheated!")
					{
						HelpLink = "http://www.CarsRUs.com",
						Data = {
							{"TimeStamp",$"The car exploded at {DateTime.Now}"},
							{"Cause","You have a lead foot."}
						}
					};
				}
				Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
			}
		}

		// IComparable implementation.
		int IComparable.CompareTo(object? obj)
		{
			if (obj is Car temp)
			{
				return this.CarID.CompareTo(temp.CarID);
			}
			throw new ArgumentException("Parameter is not a Car!");
		}

		// Property to return the PetNameComparer.
		public static IComparer SortByPetName
			=> (IComparer)new PetNameComparer();
	}
}