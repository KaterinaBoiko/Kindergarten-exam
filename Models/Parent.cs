using Models.Abstract;
using Models.Enums;
using System;

namespace Models
{
    public class Parent : Person
    {
        public string PhoneNumber { get; set; }
        public ParentType ParentType { get; set; }
        public bool IsPriority { get; set; }
    }
}
