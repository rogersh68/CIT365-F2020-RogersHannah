using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;

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

        //sorting
        public IList<JournalEntry> JournalEntries { get; set; }
        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        [BindProperty(SupportsGet = true)]
        public string sortOrder { get; set; }

       

        public async Task OnGetAsync()
            
        {
            //sorting
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<JournalEntry> journalEntries = from j in _context.JournalEntry
                                                      select j;

            switch (sortOrder)
            {
                case "book_desc":
                    journalEntries = journalEntries.OrderByDescending(j => j.Book);
                    break;
                case "Date":
                    journalEntries = journalEntries.OrderBy(j => j.EntryDate);
                    break;
                case "date_desc":
                    journalEntries = journalEntries.OrderByDescending(j => j.EntryDate);
                    break;
                default:
                    journalEntries = journalEntries.OrderBy(j => j.Book);
                    break;
            }

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
            JournalEntries = await journalEntries.AsNoTracking().ToListAsync();
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            JournalEntry = await entries.ToListAsync();
        }
    }
}
