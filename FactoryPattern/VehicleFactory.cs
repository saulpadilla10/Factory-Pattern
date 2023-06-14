using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
	

		public static IVehicle? GetVehicle(int wheels )
		{

            switch (wheels)
			{
				case 6:
					return new RV();

				case 4:
					return new Bus();

				default:
					return null;
	

			}

		}



	}
}

