using Model;
using System.Linq.Expressions;

namespace DataAccess.Services.Interfaces
{
    public interface ISectionFirstStep
    {
        public void Add(SectionFirstStep entity);
        public IEnumerable<SectionFirstStep> GetAll();
        public SectionFirstStep GetFirstOrDefault(Expression <Func<SectionFirstStep, bool>> filter);
        public void Remove(SectionFirstStep entity);
        public void RemoveRange(IEnumerable<SectionFirstStep> entities);
        public void Update(SectionFirstStep entity); 

    }
}
