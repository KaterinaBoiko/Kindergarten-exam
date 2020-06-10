using Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IChildRepository
    {
        void Add(Child child);
        void Update(Child child);
        void Delete(Guid id);
        List<Child> GetAllChildren();
        Child GetById(Guid id);
    }
}
