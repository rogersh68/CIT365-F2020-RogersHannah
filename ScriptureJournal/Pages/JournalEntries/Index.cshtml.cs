using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ScriptureJournal.Pages.JournalEntries
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Models.ScriptureJournalContext _context;

        public IndexModel(ScriptureJournal.Models.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<JournalEntry> JournalEntry { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string EntryBook { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of books.
            IQueryable<string> bookQuery = from b in _context.JournalEntry
                                           orderby b.Book
                                           select b.Book;

            var entries = from e in _context.JournalEntry
                          select e;
            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Entry.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(EntryBook))
            {
                entries = entries.Where(x => x.Book == EntryBook);
            }
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            JournalEntry = await entries.ToListAsync();
        }
    }
}
