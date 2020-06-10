using BLL.Interfaces;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

namespace Kindergarten
{
    public class ParentController
    {
        private readonly IParentService _service;

        public ParentController(IParentService parentService)
        {
            _service = parentService;
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
