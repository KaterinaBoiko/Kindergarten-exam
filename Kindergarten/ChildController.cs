﻿using BLL.Interfaces;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

namespace Kindergarten
{
    public class ChildController
    {
        private readonly IChildService _service;

        public ChildController(IChildService childService)
        {
            _service = childService;
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
