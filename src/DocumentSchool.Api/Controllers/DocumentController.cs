
using DocumentSchool.Aplication.DTOs;
using DocumentSchool.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using DocumentSchool.Aplication.Services;
using DocumentSchool.Aplication.Contract.Service;


namespace DocumentSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService service;

        public DocumentController(IDocumentService _service)
        {
            service = _service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentDTOs>>>GetAllDocument()
        {
            var getAll = await service.GetAllDocument();
            return Ok(getAll);
        }
        [HttpGet ("{id}")]
        public async Task<ActionResult<DocumentDTOs>>GetDocumentById(int id)
        {
            var getdocument = await service.GetDocument(id);

            return Ok(getdocument);
        }
        [HttpPost]
        public async Task<ActionResult>CreateDocument(DocumentDTOs document)
        {
            await service.AddDocument(document);
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult>UpdateDocument( int id, DocumentDTOs document)
        {
            await service.UpdateDocument(id, document); 
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult>DeleteDocument(int id)
        {
            await service.RemuveDocument(id);
            return NoContent();
        }
    }
}
