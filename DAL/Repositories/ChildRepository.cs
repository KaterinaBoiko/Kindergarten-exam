using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class ChildRepository : IChildRepository
    {
        private readonly IKindergartenContext _context;

        public ChildRepository(IKindergartenContext context)
        {
            _context = context;
        }

        public void Add(Child child)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Child child)
        {
            throw new NotImplementedException();
        }

        public List<Child> GetAllChildren()
        {
            throw new NotImplementedException();
        }
        public Child GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
