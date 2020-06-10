using Models;
using System;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IGroupService
    {
        void Add(Group group);
        void Update(Group group);
        void Delete(Guid id);
        List<Group> GetAllGroups();
        Group GetById(Guid id);
    }
}
