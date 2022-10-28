using DataAccess.Data;
using DataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model;
using System.Linq.Expressions;

namespace DataAccess.Services
{
    public class ServiceSectionFirstStep : ISectionFirstStep
    {
        private readonly ApplicationDbContext _db;

        public ServiceSectionFirstStep(ApplicationDbContext context)
        {
            _db = context;
        }
        public void Add(SectionFirstStep entity)
        {
            _db.SectionFirstSteps.Add(entity);
            _db.SaveChanges(true);
        }

        public IEnumerable<SectionFirstStep> GetAll()
        {
            IEnumerable<SectionFirstStep> entities = _db.SectionFirstSteps;
            return entities;
        }

        public SectionFirstStep GetFirstOrDefault(Expression<Func<SectionFirstStep, bool>> filter)
        {
            IQueryable<SectionFirstStep> entities = _db.SectionFirstSteps;
            entities = entities.Where(filter);
            return entities.FirstOrDefault();
        }

        public void Remove(SectionFirstStep entity)
        {
            _db.SectionFirstSteps.Remove(entity);
            _db.SaveChanges();
        }

        public void RemoveRange(IEnumerable<SectionFirstStep> entities)
        {
            _db.SectionFirstSteps.RemoveRange(entities);
            _db.SaveChanges();
        }

        public void Update(SectionFirstStep entity)
        {
            _db.SectionFirstSteps.Update(entity);
            _db.SaveChanges(true);
        }
    }
}
