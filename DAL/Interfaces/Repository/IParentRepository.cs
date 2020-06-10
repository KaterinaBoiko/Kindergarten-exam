using Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IParentRepository
    {
        void Add(Parent parent);
        void Update(Parent parent);
        void Delete(Guid id);
        List<Parent> GetAllParents();
        Parent GetById(Guid id);
    }
}
