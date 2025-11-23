using Dto;

namespace Bll
{
    public class BllClass:IBll.BllInterface
    {


        IDal.DalInterface e;
        public BllClass(IDal.DalInterface e)
        {
            this.e = e;
        }
        public async Task<List<DtoEvent>> GetAllEvents()
        {
            //אולי בעתיד יהיה כאן לוגיקה
            return await this.e.GetAllEvents();
        }

    }
}
