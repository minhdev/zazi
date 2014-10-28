using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using zazi.Models;

namespace zazi.Services
{
    public class NotebookServices : INotebookServices
    {
        private NoteDataContext dbNotebook = new NoteDataContext();

        public IList<Models.NoteEntry> GetEntries()
        {
            return dbNotebook.Entries.ToList();
        }

        public IList<Models.NoteEntry> GetEntriesByName(string name)
        {
            var entries =
               dbNotebook.Entries.Where(g => g.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            return entries.ToList();
        }

        public void AddEntry(Models.NoteEntry entry)
        {
            entry.DateCreated = DateTime.Now;
            dbNotebook.Entries.Add(entry);
            dbNotebook.SaveChanges();
        }

        public void Dispose()
        {
            dbNotebook.Dispose();
        }
    }
}