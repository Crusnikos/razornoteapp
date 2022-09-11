using LinqToDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesNoteManagerApp.Data;
using RazorPagesNoteManagerApp.Data.Models;

namespace RazorPagesNoteManagerApp.Pages.Index
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

        [BindProperty]
        public SortedNotes NotesData { get; set; }

        public async Task OnGet()
        {
            await using var db = _databaseFactory();

            NotesData = new SortedNotes
            {
                Notes = await db.Notes.Where(n => n.AnswerOn == null).ToListAsync(HttpContext.RequestAborted),
                NotesAnswers = await db.Notes.Where(n => n.AnswerOn != null).ToListAsync(HttpContext.RequestAborted)
            };
        }
    }
}