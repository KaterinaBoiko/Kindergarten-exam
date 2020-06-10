using System;
using System.Collections.Generic;

namespace Models
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Educator Educator { get; set; }
        public List<Child> Children { get; set; }
    }
}
