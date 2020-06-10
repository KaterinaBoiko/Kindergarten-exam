using BLL.Interfaces;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

namespace Kindergarten
{
    public class EducatorController
    {
        private readonly IEducatorService _service;

        public EducatorController(IEducatorService educatorService)
        {
            _service = educatorService;
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
