﻿using System;

namespace P05_Birthday_Celebrations.Contracts
{
    public interface ICitizen
    {
        public string Name { get; }
        public string Age { get; }
        public string Id { get; }
    }
}
