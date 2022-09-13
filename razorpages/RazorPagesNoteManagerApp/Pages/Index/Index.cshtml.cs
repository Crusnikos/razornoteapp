using LinqToDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesNoteManagerApp.Data;
using System.Threading;

namespace RazorPagesNoteManagerApp.Pages.Index;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly Database.Factory _databaseFactory;
    private const int DefaultPageSize = 5;

    public IndexModel(ILogger<IndexModel> logger, Database.Factory databaseFactory)
    {
        _logger = logger;
        _databaseFactory = databaseFactory;
    }

    [BindProperty]
    public SortedNotes NotesData { get; set; }

    [BindProperty(SupportsGet = true)]
    public int DisplayPage { get; set; } = 1;

    public async Task OnGet()
    {
        await using var db = _databaseFactory();

        var pageOffset = DefaultPageSize * (DisplayPage - 1);
        var notesCount = await db.Notes.Where(n => n.AnswerOn == null).CountAsync(HttpContext.RequestAborted);

        var notes = await db.Notes.
            Where(n => n.AnswerOn == null).
            OrderBy(n => n.NoteId).
            Skip(pageOffset).
            Take(DefaultPageSize).
            ToListAsync(HttpContext.RequestAborted);

        var NotesAnswers = await db.Notes.
            Where(n => n.AnswerOn != null && n.AnswerOn > pageOffset && n.AnswerOn < pageOffset + DefaultPageSize).
            ToListAsync(HttpContext.RequestAborted);

        NotesData = new SortedNotes
        {
            Notes = notes,
            NotesAnswers = NotesAnswers,
            NotesCount = notesCount,
            PagesCount = notesCount % DefaultPageSize == 0 ? notesCount / DefaultPageSize : notesCount / DefaultPageSize + 1
        };
    }
}