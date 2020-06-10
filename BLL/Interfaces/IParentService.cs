using Models;
using System;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IParentService
    {
        void Add(Parent parent);
        void Update(Parent parent);
        void Delete(Guid id);
        List<Parent> GetAllParents();
        Parent GetById(Guid id);
    }
}
