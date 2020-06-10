using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace DAL.KindergartenContext
{
    public class KindergartenContext : DbContext, IKindergartenContext
    {
        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Educator> Educators { get; set; }
        public KindergartenContext(DbContextOptions<KindergartenContext> options)
            : base(options)
        { }
    }
}
