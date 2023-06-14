using System;
namespace FactoryPattern
{
	public class RV : IVehicle
	{
		public RV()
		{
		}

		public void Drive()
		{

			Console.WriteLine("RV is a vehicle. A RECRATIONAL vehicle. Have fun!");

		}

	}
}

