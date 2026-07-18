using DocumentSchool.Aplication.DTOs;
using DocumentSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.Aplication.Contract.Service
{
   
    public interface IDocumentService
    {
        public Task AddDocument(DocumentDTOs document);
        public Task<DocumentDTOs> GetDocument(int id);
        public Task<IEnumerable<DocumentDTOs>> GetAllDocument();
        public Task RemuveDocument(int id);
        public Task UpdateDocument(int id, DocumentDTOs document);

    }
}
