using LinqToDB.Mapping;

namespace RazorPagesNoteManagerApp.Data.Models;

[Table("note")]
public class Note
{
    [Column("note_id")]
    [PrimaryKey]
    [NotNull]
    [Identity]
    public long NoteId { get; set; }

    [Column("article_id")]
    [NotNull]
    public long ArticleId { get; set; }

    [Column("note")]
    [NotNull]
    public string Text { get; set; } = default!;

    [Column("author")]
    [NotNull]
    public string Author { get; set; } = default!;

    [Column("created_at")]
    [NotNull]
    public DateTimeOffset CreatedAt { get; set; }

    [Column("edited_by")]
    public string? EditedBy { get; set; }

    [Column("edited_at")]
    public DateTimeOffset? EditedAt { get; set; }

    [Column("answer_on")]
    public long? AnswerOn { get; set; }

    [Column("voted_up")]
    public int? VotedUp { get; set; }

    [Column("voted_down")]
    public int? VotedDown { get; set; }

    [Column("hided")]
    [NotNull]
    public bool Hided { get; set; } = default!;
}
