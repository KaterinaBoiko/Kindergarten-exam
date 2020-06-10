using System;

namespace Models.Abstract
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
