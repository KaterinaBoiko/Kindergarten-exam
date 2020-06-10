using BLL.Interfaces;
using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ChildService : IChildService
    {
        private readonly IChildRepository _repository;

        public ChildService(IChildRepository childRepository)
        {
            _repository = childRepository;
        }

        public void Add(Child child)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
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

        public void Update(Child child)
        {
            throw new NotImplementedException();
        }
    }
}
