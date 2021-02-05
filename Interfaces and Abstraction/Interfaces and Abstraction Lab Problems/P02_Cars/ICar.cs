using System;

namespace Cars
{
    public interface ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public void Start()
        {
            Console.WriteLine("Engine start");
        }

        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }
    }
}
