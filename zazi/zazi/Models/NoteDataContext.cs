using System.Data.Entity;

namespace zazi.Models
{
    public class NoteDataContext : DbContext
    {
        /// <summary>
        /// Constructor to define database name
        /// If we dont define, EF will use default zazi.Models.NoteDataContext.mdf
        /// </summary>
        public NoteDataContext()
            : base("Notebook")
        {
        }

        /// <summary>
        /// Provide access to table data
        /// </summary>
        public DbSet<NoteEntry> Entries { get; set; }
    }
}