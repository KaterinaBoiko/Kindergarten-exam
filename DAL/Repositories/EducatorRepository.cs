using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class EducatorRepository : IEducatorRepository
    {
        private readonly IKindergartenContext _context;

        public EducatorRepository(IKindergartenContext context)
        {
            _context = context;
        }

        public void Add(Educator educator)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Educator educator)
        {
            throw new NotImplementedException();
        }

        public List<Educator> GetAllEducators()
        {
            throw new NotImplementedException();
        }
        public Educator GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
