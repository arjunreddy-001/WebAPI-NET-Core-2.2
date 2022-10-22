using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_2._2.Models;

namespace WebAPI_2._2.Services.CalenderEntryService
{
    public interface ICalenderEntryService
    {
        IList<CalenderEntry> GetCalenderEntries();

        IList<CalenderEntry> CreateCalenderEntry(CalenderEntry entry);
    }
}
