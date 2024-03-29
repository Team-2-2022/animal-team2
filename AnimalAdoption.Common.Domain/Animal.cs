﻿namespace AnimalAdoption.Common.Domain
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}