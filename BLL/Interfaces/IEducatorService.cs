using Models;
using System;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IEducatorService
    {
        void Add(Educator educator);
        void Update(Educator educator);
        void Delete(Guid id);
        List<Educator> GetAllEducators();
        Educator GetById(Guid id);
    }
}
