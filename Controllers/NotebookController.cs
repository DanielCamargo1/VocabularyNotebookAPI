using Microsoft.AspNetCore.Mvc;
using VocabularyNotebookApi.Data;
using VocabularyNotebookApi.Models;

namespace VocabularyNotebookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotebookController : ControllerBase
    {
        private readonly NotebookDbContext _context;

        public NotebookController( NotebookDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<NotebookDbContext>>> GetWords()
        //{
        //    return Ok(_context.Notebook.ToListAsync()) ;
        //}
    }
}
