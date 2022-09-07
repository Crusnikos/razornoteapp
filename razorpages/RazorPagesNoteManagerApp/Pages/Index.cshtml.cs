using LinqToDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesNoteManagerApp.Data;
using RazorPagesNoteManagerApp.Data.Models;

namespace RazorPagesNoteManagerApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Database.Factory _databaseFactory;

        public IndexModel(ILogger<IndexModel> logger, Database.Factory databaseFactory)
        {
            _logger = logger;
            _databaseFactory = databaseFactory;
        }

        protected async Task<List<Note>> GetNotes(CancellationToken cancellationToken = default)
        {
            await using var db = _databaseFactory();

            return await db.Notes.ToListAsync(cancellationToken);
        }

        [BindProperty]
        public List<Note> NotesData { get; set; }

        public async Task OnGet()
        {
            NotesData = new List<Note>();

            NotesData.Add(new Note 
            {
                NoteId = 1,
                ArticleId = 1,
                Text = "Just simple note",
                Author = "michalkubrak.90@gmail.com",
                CreatedAt = DateTime.Now,
                Hided = false
            });

            NotesData.Add(new Note
            {
                NoteId = 2,
                ArticleId = 1,
                Text = "Just another simple note",
                Author = "michalkubrak.90@gmail.com",
                CreatedAt = DateTime.Now,
                Hided = false
            });

            NotesData.Add(new Note
            {
                NoteId = 3,
                ArticleId = 1,
                Text = "Just another, another simple note",
                Author = "michalkubrak.90@gmail.com",
                CreatedAt = DateTime.Now,
                Hided = false
            });
        }
    }
}