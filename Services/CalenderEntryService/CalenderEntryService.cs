using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_2._2.Models;

namespace WebAPI_2._2.Services.CalenderEntryService
{
    public class CalenderEntryService : ICalenderEntryService
    {
        private IList<CalenderEntry> entries = new List<CalenderEntry>();

        public IList<CalenderEntry> CreateCalenderEntry(CalenderEntry entry)
        {
            entries.Add(entry);
            return entries;
        }

        public IList<CalenderEntry> GetCalenderEntries()
        {
            CalenderEntry newEntry = new CalenderEntry();

            newEntry.Date = DateTime.Now;
            newEntry.Title = "My new project";

            entries.Add(newEntry);

            return entries;
        }
    }
}
