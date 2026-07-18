using DocumentSchool.Aplication.Contract.Service;
using DocumentSchool.Aplication.DTOs;
using DocumentSchool.Aplication.Repository;
using DocumentSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.Aplication.Services
{
    public class DocumentService : IDocumentService
    {

        private readonly IDocumentRepository service;

        public DocumentService(IDocumentRepository _service)
        {
            service = _service;
        }
        public async Task AddDocument(DocumentDTOs document)
        {
            var Doc = new Docment
            {
                NameDocument = document.NameDocument,
                RequestId = document.RequestId,

            };
            await service.AddDocument(Doc);
            


        }

        public async Task<IEnumerable<DocumentDTOs>> GetAllDocument()
        {
            var getalldocument = await service.GetAllDocument();

                var alldocument = getalldocument.Select(x => new DocumentDTOs
                {
                    NameDocument = x.NameDocument,
                    RequestId = x.RequestId
                });
            return alldocument;
        }

        public async Task<DocumentDTOs> GetDocument(int id)
        {
            var getdocument = await service.GetDocument(id);

            var gdocument = new DocumentDTOs
            {
                NameDocument = getdocument.NameDocument,
                RequestId = getdocument.RequestId
            };
            return gdocument;
        }

        public async Task RemuveDocument(int id)
        {
            await service.RemuveDocument(id);

        }

        public async Task UpdateDocument(int id, DocumentDTOs document)
        {
            var updoc = new Docment
            {
                NameDocument = document.NameDocument,
                RequestId = document.RequestId,
            };
            await service.UpdateDocument(id, updoc);
        }
    }
}
