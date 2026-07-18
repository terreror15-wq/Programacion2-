using DocumentSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSchool.Aplication.Repository
{
    public interface IDocumentRepository
    {
        public Task AddDocument(Docment document);
        public Task<Docment>GetDocument(int id);
        public Task<IEnumerable<Docment>>GetAllDocument();
        public Task RemuveDocument(int id);
        public Task UpdateDocument(int id, Docment document);

    }
}
