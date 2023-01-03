using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Model;
using System.Globalization;
namespace DataAccess.Services
{
    public class ServiceSectionFirstStep
    {
        private readonly ApplicationDbContext _context;

        public ServiceSectionFirstStep(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<SectionFirstStep>> GetAllAsync()
        {
            var Data = await _context.SectionFirstSteps!.Where(m => m.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name).OrderByDescending(m => m.CreateDate).ToListAsync();
            return Data;
        }

        public async Task<SectionFirstStep> GetByIdAsync(int? id)
        {
            var Data=await _context.SectionFirstSteps!.FirstOrDefaultAsync(m => m.Id == id);
            return Data!;
        }
        public async Task AddAsync(SectionFirstStep entityToAdd)
        {
            _context.Add(entityToAdd);
            await _context.SaveChangesAsync();

        }
        public async Task UpdateAsync(SectionFirstStep entityToEdit)
        {
            _context.Update(entityToEdit);
            await _context.SaveChangesAsync();
        }
        public async Task RemoveAsync(SectionFirstStep entityToDelete)
        {
            _context.Remove(entityToDelete);
            await _context.SaveChangesAsync();
        }
        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
        public bool SectionFirstStepExistsAsync(int id)
        {
            return _context.SectionFirstSteps!.Any(e => e.Id == id);
        }
        public int LanguageId()
        {
            return _context.SectionLanguages!.First(l => l.Name == CultureInfo.CurrentCulture.Name).Id;
        }



    }

}
