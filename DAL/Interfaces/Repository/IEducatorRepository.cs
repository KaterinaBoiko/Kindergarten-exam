using Models;
using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IEducatorRepository
    {
        void Add(Educator group);
        void Update(Educator group);
        void Delete(Guid id);
        List<Educator> GetAllEducators();
        Educator GetById(Guid id);
    }
}
