using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace DAL.Interfaces
{
    public interface IKindergartenContext
    {
        DbSet<Child> Children { get; set; }
        DbSet<Parent> Parents { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Educator> Educators { get; set; }
    }
}
