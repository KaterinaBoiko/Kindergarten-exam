using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly IKindergartenContext _context;

        public GroupRepository(IKindergartenContext context)
        {
            _context = context;
        }

        public void Add(Group group)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Group group)
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
    }
}
