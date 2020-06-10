using Models.Abstract;
using System;
using System.Collections.Generic;

namespace Models
{
    public class Child : Person
    {
        public List<Parent> Parents { get; set; }
    }
}
