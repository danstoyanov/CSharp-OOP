﻿
using P05_Birthday_Celebrations.Contracts;

namespace P05_Birthday_Celebrations.Models
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
