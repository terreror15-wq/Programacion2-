using DocumentSchool.InfraEstructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.InfraEstructure.Context
{
    public class DocumentSchoolDbContext(DbContextOptions<DocumentSchoolDbContext> options) : DbContext(options)
    {
        public DbSet<DocumentModel>Docs { get; set; }
        public DbSet<RegistrerModel>Registers { get; set; }
        public DbSet<RequestModel>Request { get; set; }
        public DbSet<StudentModel>Student { get; set; }
    }
}
