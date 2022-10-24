using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_2._2.Data;
using WebAPI_2._2.Models;

namespace WebAPI_2._2.Services.CalenderEntryService
{
    public class CalenderEntryService : ICalenderEntryService
    {
        private readonly DataContext _context;
        private IList<CalenderEntry> entries = new List<CalenderEntry>();

        public CalenderEntryService(DataContext context)
        {
            _context = context;
        }

        public IList<CalenderEntry> CreateCalenderEntry(CalenderEntry entry)
        {
            _context.CalenderEntries.Add(entry);
            _context.SaveChanges();

            return _context.CalenderEntries.ToList();

            //entries.Add(entry);
            //return entries;
        }

        public IList<CalenderEntry> DeleteCalenderEntry(int id)
        {
            CalenderEntry entryToDelete = _context.CalenderEntries.FirstOrDefault(e => e.Id == id);

            _context.CalenderEntries.Remove(entryToDelete);
            _context.SaveChanges();

            return _context.CalenderEntries.ToList();
        }

        public IList<CalenderEntry> GetCalenderEntries()
        {
            IList<CalenderEntry> entries = _context.CalenderEntries.ToList();
            return entries;
            
            //CalenderEntry newEntry = new CalenderEntry();

            //newEntry.Date = DateTime.Now;
            //newEntry.Title = "My new project";

            //entries.Add(newEntry);

            //return entries;
        }

        public CalenderEntry GetCalenderEntry(int id)
        {
            return _context.CalenderEntries.FirstOrDefault(e => e.Id == id);
        }

        public IList<CalenderEntry> UpdateCalenderEntry(CalenderEntry entry)
        {
            CalenderEntry entryToUpdate = _context.CalenderEntries.FirstOrDefault(e => e.Id == entry.Id);

            entryToUpdate.Date = entry.Date;
            entryToUpdate.Title = entry.Title;

            _context.CalenderEntries.Update(entryToUpdate);
            _context.SaveChanges();

            return _context.CalenderEntries.ToList();
        }
    }
}
