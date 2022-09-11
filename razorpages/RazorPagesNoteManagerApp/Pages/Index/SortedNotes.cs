﻿using RazorPagesNoteManagerApp.Data.Models;

namespace RazorPagesNoteManagerApp.Pages.Index;

public class SortedNotes
{
    public IReadOnlyList<Note> Notes { get; set; } = default!;

    public IReadOnlyList<Note> NotesAnswers { get; set; } = default!;
}
