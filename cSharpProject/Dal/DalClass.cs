using Dal.converters;
using Dal.models;
using Dto;
using Microsoft.EntityFrameworkCore;

namespace Dal
{
    public class DalClass:IDal.DalInterface
    {

        EventStoreContext db;
        public DalClass(EventStoreContext db)
        {
            this.db = db;

        }
        public async Task<List<DtoEvent>> GetAllEvents()
        {       
            var tlist = await db.Events.ToListAsync();
            return EventConverter.ToDtoList(tlist);
        }


    }
}
