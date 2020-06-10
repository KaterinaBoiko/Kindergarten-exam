using Models;
using System;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IChildService
    {
        void Add(Child child);
        void Update(Child child);
        void Delete(Guid id);
        List<Child> GetAllChildren();
        Child GetById(Guid id);
    }
}
