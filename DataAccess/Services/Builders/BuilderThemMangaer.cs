﻿using DataAccess.Data;

namespace DataAccess.Services.Builders
{
    public class BuilderThemMangaer
    {
        private readonly ApplicationDbContext _db;

        public BuilderThemMangaer(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool CheckActiveTime()
        {
            var control = _db.WebsiteActiveTimeControls!.Where(m => m.Id == 1).FirstOrDefault();
            if (control != null && control.Active)
            {
                if (!control.Timable)
                {
                    return true;
                }
                else
                {

                    if (control.StartDate <= System.DateTime.Now && System.DateTime.Now <= control.EndDate)
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
            var WebsiteTitle = _db.WebsiteActiveTimeControls!.Find(1);
            if (WebsiteTitle != null)
                return WebsiteTitle.WebsiteTitle;
            return null;
        }
        public Dictionary<string,bool> CheckThemSections()
        {
            Dictionary<string, bool> ThemControlDictionary = new Dictionary<string, bool>();
            var DataThemControl = _db.WebsiteThemControls!.ToList();
            foreach (var Data in DataThemControl)
            {
                if (Data.Active)
                {
                    if (!Data.Timable)
                    {
                        ThemControlDictionary.Add(Data.SectionName!, Data.Active);
                    }
                    else
                    {
                        if (Data.StartDate <= System.DateTime.Now && System.DateTime.Now <= Data.EndDate)
                        {
                            ThemControlDictionary.Add(Data.SectionName!, true);
                        }
                        else
                        {
                            ThemControlDictionary.Add(Data.SectionName!, false);
                        }
                    }
                }
                else
                {
                    ThemControlDictionary.Add(Data.SectionName!, false);
                }
            }
            return ThemControlDictionary;
        }
    }
}