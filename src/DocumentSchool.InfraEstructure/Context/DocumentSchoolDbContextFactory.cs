using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.InfraEstructure.Context
{
    public class DocumentSchoolDbContextFactory : IDesignTimeDbContextFactory<DocumentSchoolDbContext>
    {
        public DocumentSchoolDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DocumentSchoolDbContext>();


            optionsBuilder.UseNpgsql("Host=aws-1-us-west-2.pooler.supabase.com;Database=postgres;Username=postgres.fkqvfusnukpedcptjxsw;Password=Terrero1997!;SSL Mode=Require;Trust Server Certificate=true");
                

            return new DocumentSchoolDbContext(optionsBuilder.Options);
        }
    }
}
