using System;
namespace FactoryPattern
{
	public class Bus : IVehicle
	{
		public Bus()
		{
		}

		public void Drive()
		{
			Console.WriteLine("Bus is a vehicle. A vehicle called a bus.");

		}
	}
}

