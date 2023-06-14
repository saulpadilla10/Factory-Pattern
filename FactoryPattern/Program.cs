namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER amount of wheels:");
            int wheels;
            var answer = int.TryParse(Console.ReadLine(), out wheels);

            if (wheels == 4)

            {
                Console.WriteLine("New Bus.");

            }
            else if (wheels == 6)

            {
                Console.WriteLine("New RV.");
            }
            else
            {
                Console.WriteLine("No vehicle available.");
            }

            var vehicle = VehicleFactory.GetVehicle(wheels);
            vehicle.Drive();

        }
    }
}
