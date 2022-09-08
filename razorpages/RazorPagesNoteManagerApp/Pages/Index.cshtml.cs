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

        [BindProperty]
        public List<Note> NotesData { get; set; }

        public async Task OnGet()
        {
            NotesData = await _databaseFactory().Notes.ToListAsync();
        }
    }
}