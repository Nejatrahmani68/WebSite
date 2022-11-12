using DataAccess.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class ServiceAdminControl
    {
        private readonly ApplicationDbContext _db;
        public ServiceAdminControl(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool CheckAdmin(String userName)
        {
            //Check Admin WorkTime
            var AdminControl = _db.WebsiteAdminsControls.FirstOrDefault(m => m.Email == userName);
            if (AdminControl != null)
            {
                if (AdminControl.Active == false || (AdminControl.Timable == true && System.DateTime.Now < AdminControl.StartDate || System.DateTime.Now > AdminControl.EndDate))
                {
                    return false;
                }
            }
            return true;
        }
    }
}