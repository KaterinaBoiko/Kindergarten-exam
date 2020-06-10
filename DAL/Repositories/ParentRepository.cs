using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class ParentRepository : IParentRepository
    {
        private readonly IKindergartenContext _context;

        public ParentRepository(IKindergartenContext context)
        {
            _context = context;
        }

        public void Add(Parent parent)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Parent parent)
        {
            throw new NotImplementedException();
        }

        public List<Parent> GetAllParents()
        {
            throw new NotImplementedException();
        }
        public Parent GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
