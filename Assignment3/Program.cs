using System;
namespace Assignment3
{
    public class Car
    {
        // Private member variables
        private string brand;
        private string model;
        private int speed;

        // Constructor to initialize the car
        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
            this.speed = 0;
        }

        // Method to start the engine
        private void StartEngine()
        {
            Console.WriteLine($"The {brand} {model}'s engine is started.");
        }

        // Method to accelerate the car
        public void Accelerate(int increaseSpeed)
        {
            if (increaseSpeed > 0)
            {
                speed += increaseSpeed;
                Console.WriteLine($"The {brand} {model} is accelerating. Current speed: {speed} km/h.");
            }
            else
            {
                Console.WriteLine("Invalid speed increase. Please provide a positive value.");
            }
        }

        // Method to brake the car
        public void Brake(int decreaseSpeed)
        {
            if (decreaseSpeed > 0)
            {
                if (speed - decreaseSpeed >= 0)
                {
                    speed -= decreaseSpeed;
                    Console.WriteLine($"The {brand} {model} is braking. Current speed: {speed} km/h.");
                }
                else
                {
                    Console.WriteLine("The car cannot go below 0 km/h. It has stopped.");
                    speed = 0;
                }
            }
            else
            {
                Console.WriteLine("Invalid speed decrease. Please provide a positive value.");
            }
        }

        // Method to display information about the car
        public void DisplayInfo()
        {
            Console.WriteLine($"Car Information: {brand} {model}, Current Speed: {speed} km/h");
        }

        // Example of a private method being called from a public method
        public void Drive()
        {
            StartEngine();
            Accelerate(30);
            Brake(10);
            DisplayInfo();
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an instance of the Car class
            Car myCar = new Car("Toyota", "Camry");

            // Using the car object
            myCar.Drive();
        }
    }
}