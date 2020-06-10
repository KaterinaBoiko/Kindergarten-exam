using BLL.Interfaces;
using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _repository;

        public GroupService(IGroupRepository groupRepository)
        {
            _repository = groupRepository;
        }

        public void Add(Group group)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAllGroups()
        {
            throw new NotImplementedException();
        }

        public Group GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Group group)
        {
            throw new NotImplementedException();
        }
    }
}
