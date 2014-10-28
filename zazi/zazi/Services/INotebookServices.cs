using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zazi.Models;

namespace zazi.Services
{
    public interface INotebookServices : IDisposable
    {
        IList<NoteEntry> GetEntries(); 
        IList<NoteEntry> GetEntriesByName(string name);
        void AddEntry(NoteEntry entry);
    }
}
