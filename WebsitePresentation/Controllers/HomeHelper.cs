using DataAccess;
using DataAccess.Data;

namespace WebsitePresentation.Controllers
{
    public class HomeHelper
    {
        private readonly ApplicationDbContext _db;

        public HomeHelper(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CheckActiveTime()
        {
            var control = _db.WebsiteActiveTimeControls.Where(m=>m.Id==1).FirstOrDefault();
            if (control != null && control.Active)
            {
                if (!control.Timable)
                {
                    return true;
                }
                else
                {

                    if (control.StartDate < System.DateTime.Now && System.DateTime.Now > control.EndDate)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public string? ReturnWebsiteTitle()
        {
            var WebsiteTitle  = _db.WebsiteActiveTimeControls.Find(1);
            if(WebsiteTitle != null)
            return WebsiteTitle.WebsiteTitle;
            return null;
        }
    }
}
