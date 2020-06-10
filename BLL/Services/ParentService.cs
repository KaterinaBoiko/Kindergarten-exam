using BLL.Interfaces;
using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class ParentService : IParentService
    {
        private readonly IParentRepository _repository;

        public ParentService(IParentRepository parentRepository)
        {
            _repository = parentRepository;
        }

        public void Add(Parent parent)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
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

        public void Update(Parent parent)
        {
            throw new NotImplementedException();
        }
    }
}
