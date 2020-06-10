using Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IGroupRepository
    {
        void Add(Group group);
        void Update(Group group);
        void Delete(Guid id);
        List<Group> GetAllGroups();
        Group GetById(Guid id);
    }
}
