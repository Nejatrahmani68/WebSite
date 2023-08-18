using DataAccess.Data;

namespace DataAccess.Services
{
    public class ServiceAdminControl
    {
        private readonly ApplicationDbContext _db;
        public ServiceAdminControl(ApplicationDbContext db)
        {
            _db = db;
        }
        //Check Admin WorkTime
        public bool CheckAdmin(String userName)
        {
            var AdminControl = _db.WebsiteAdminsControls!.FirstOrDefault(m => m.Email == userName);
            if (AdminControl != null)
            {
                if (AdminControl.Active == false || (AdminControl.Timable == true && System.DateTime.Now < AdminControl.StartDate || System.DateTime.Now > AdminControl.EndDate))
                {
                    return false;
                }
            }
            return true;
        }
        //WebsiteTitle

        public string WebsiteTitle()
        {
            string fillData = _db.WebsiteActiveTimeControls!.Find(1)!.WebsiteTitle!;
            return fillData;
        }
    }
}