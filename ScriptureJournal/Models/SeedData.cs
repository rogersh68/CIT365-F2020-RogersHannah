using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(serviceProvider.GetRequiredService<DbContextOptions<ScriptureJournalContext>>()))
            {
                // Look for any journal entries
                if (context.JournalEntry.Any())
                {
                    return; //DB has been seeded
                }

                context.JournalEntry.AddRange(
                    new JournalEntry
                    {
                        EntryDate = DateTime.Parse("2020-10-26"),
                        Book = "Alma",
                        Chapter = 32,
                        Verse = 27,
                        Scripture = "But behold, if ye will awake and arouse your faculties, even to an experiment upon my words, and exercise a particle of faith, yea, even if ye can no more than desire to believe, let this desire work in you, even until ye believe in a manner that ye can give place for a portion of my words.",
                        Entry = "I love this scripture because we don't have to believe right away, we can just have a desire to believe. That desire can grow into beleif and into faith."
                    },

                    new JournalEntry
                    {
                        EntryDate = DateTime.Parse("2020-10-27"),
                        Book = "Alma",
                        Chapter = 33, 
                        Verse = 8,
                        Scripture = "Yea, thou art merciful unto thy children when they cry unto thee, to be heard of thee and not of men, and thou wilt hear them.",
                        Entry = "If we are sincere in our intent, God will hear us and answer our prayers."
                    },

                    new JournalEntry
                    {
                        EntryDate = DateTime.Parse("2020-10-27"),
                        Book = "3 Nephi",
                        Chapter = 18,
                        Verse = 15,
                        Scripture = "Verily, verily, I say unto you, ye must watch and pray always, lest ye be tempted by the devil, and ye be led away captive by him.",
                        Entry = "We should always pray to be strong against temptation."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
