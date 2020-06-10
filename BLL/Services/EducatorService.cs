using BLL.Interfaces;
using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class EducatorService : IEducatorService
    {
        private readonly IEducatorRepository _repository;

        public EducatorService(IEducatorRepository educatorRepository)
        {
            _repository = educatorRepository;
        }

        public void Add(Educator educator)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
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

        public void Update(Educator educator)
        {
            throw new NotImplementedException();
        }
    }
}
