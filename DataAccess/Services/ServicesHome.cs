using DataAccess.Data;
using DataAccess.Services.Builders;
using Model.ViewModels;

namespace DataAccess.Services
{
    public class ServicesHome
    {
        private readonly ApplicationDbContext _db;
        private readonly ViewModelHomePage _viewModelHomePage;

        public ServicesHome(ApplicationDbContext db, ViewModelHomePage viewModelHomePage)
        {
            _db = db;
            _viewModelHomePage = viewModelHomePage;
        }
        public ViewModelHomePage FillHomapageModel()
        {
            BuilderThemMangaer builderThemMangaer = new BuilderThemMangaer(_db, _viewModelHomePage);
            BuilderFillData builderFillData = new BuilderFillData(_db, _viewModelHomePage);
            _viewModelHomePage.IsActive = builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.checkThemDictionary = builderThemMangaer.CheckThemSections();
            _viewModelHomePage.sectionFirstSteps = builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionPostTop10Steps = builderFillData.FillPostStepSectionTop10Data();
            _viewModelHomePage.sectionPostImages = builderFillData.FillSectionPostImageData();
            return _viewModelHomePage;
        }



    }
}