using DocumentSchool.Domain.Interfaces;
using DocumentSchool.DTOs;
using DocumentSchool.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace DocumentSchool.Domain.DTOs
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentRepository repo;

        public DocumentController(IDocumentRepository _repo)
        {
            repo = _repo;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentDTOs>>>GetAllDocument()
        {
            var getAll = await repo.GetAllDocument();
            return Ok(getAll);
        }
        [HttpGet ("{id}")]
        public async Task<ActionResult<DocumentDTOs>>GetDocumentById(int id)
        {
            var getdocument = await repo.GetDocument(id);

            var ndocument = new DocumentDTOs
            {
                NameDocument = getdocument.NameDocument

            };
            return Ok(ndocument);
        }
        [HttpPost]
        public async Task<ActionResult>CreateDocument(DocumentDTOs document)
        {
            var Ndocument = new Docment
            {
                NameDocument = document.NameDocument,
                RequestId = document.RequestId
            };
            await repo.AddDocument(Ndocument);
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult>UpdateDocument( int id, DocumentDTOs document)
        {
            var UpDocument = new Docment
            {
                NameDocument = document.NameDocument
            };
             await repo.UpdateDocument(id, UpDocument);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult>DeleteDocument(int id)
        {
            await repo.RemuveDocument(id);
            return NoContent();
        }
    }
}
