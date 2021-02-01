using P04_Border_Control.Contracts;

namespace P04_Border_Control.Models
{
    public class Robot : IRobot, IInhabitants
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; private set; }

        public string Id { get; private set; }
    }
}
