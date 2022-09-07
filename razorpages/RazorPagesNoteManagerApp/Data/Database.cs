using LinqToDB;
using LinqToDB.Data;
using RazorPagesNoteManagerApp.Data.Models;

namespace RazorPagesNoteManagerApp.Data;

public class Database : DataConnection
{
    public delegate Database Factory();

    public Database(string connectionString) : base(
        ProviderName.PostgreSQL95,
        connectionString
    )
    {
    }

    public ITable<Note> Notes => this.GetTable<Note>();
}
