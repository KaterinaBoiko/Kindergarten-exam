using BLL.Interfaces;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

namespace Kindergarten
{
    public class GroupController
    {
        private readonly IGroupService _service;

        public GroupController(IGroupService groupService)
        {
            _service = groupService;
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
