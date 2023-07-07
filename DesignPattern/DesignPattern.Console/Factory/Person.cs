﻿namespace DesignPattern.Console.Factory
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
    }
}
