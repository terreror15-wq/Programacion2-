using DocumentSchool.Domain.Interfaces;
using DocumentSchool.Entities;
using DocumentSchool.InfraEstructure.Context;
using DocumentSchool.InfraEstructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DocumentSchool.InfraEstructure.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly DocumentSchoolDbContext repo;

        public DocumentRepository(DocumentSchoolDbContext _repo)
        {
            repo = _repo; 
        }


        public async Task AddDocument(Docment document)
        {
            var Ndoc = new DocumentModel
            {
                NameDocument = document.NameDocument,
                RequestId = document.RequestId
                
                
                



            };
            await repo.Docs.AddAsync(Ndoc);
            await repo.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<Docment>> GetAllDocument() 
        {
            var docs = await repo.Docs.AsNoTracking().ToListAsync();
            var document = docs.Select(x => new Docment
            {
                NameDocument = x.NameDocument,
                RequestId = x.RequestId
               
                
            });
            return document;
        }

        public async Task<Docment> GetDocument(int id)
        {
            var document = await repo.Docs.FindAsync(id);
            var doc = new Docment
            {
                NameDocument = document.NameDocument,
                RequestId = document.RequestId


            };
            return doc;

        }

        public async Task RemuveDocument(int id)
        {
            var doc = await repo.Docs.FindAsync(id);
            repo.Docs.Remove(doc);

            await repo.SaveChangesAsync(); 
        }


        public async Task UpdateDocument(int id, Docment document)
        {
            var doc = await repo.Docs.FindAsync(id);
            if(doc is null) 
            {
                return;
            }
            
            doc.NameDocument = document.NameDocument;

            await repo.SaveChangesAsync();     
            
        }

    }
}
