using P06_Food_Shortage.Contracts;

namespace P06_Food_Shortage.Models
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
