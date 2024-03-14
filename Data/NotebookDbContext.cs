using Microsoft.EntityFrameworkCore;
using VocabularyNotebookApi.Models;

namespace VocabularyNotebookApi.Data
{
    public class NotebookDbContext : DbContext {  
        public NotebookDbContext(DbContextOptions<NotebookDbContext> options) : base(options)
        {

        }

        DbSet<NotebookModel> Notebook { get; set; }
    }
}
