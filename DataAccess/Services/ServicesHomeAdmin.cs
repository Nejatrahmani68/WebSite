using DataAccess.Data;
using DataAccess.Services.Builders;
using Model;
using Model.ViewModels;

namespace DataAccess.Services
{
    public class ServicesHomeAdmin
    {
        private readonly ApplicationDbContext _db;
        private readonly ViewModelHomePage _viewModelHomePage;

        public ServicesHomeAdmin(ApplicationDbContext db, ViewModelHomePage viewModelHomePage)
        {
            _db = db;
            _viewModelHomePage = viewModelHomePage;
        }
        public ViewModelHomePage FillHomapageAdminModel()
        {
            BuilderThemMangaer builderThemMangaer = new BuilderThemMangaer(_db, _viewModelHomePage);
            BuilderFillData builderFillData = new BuilderFillData(_db, _viewModelHomePage);
            _viewModelHomePage.IsActive = builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.checkThemDictionary = builderThemMangaer.CheckThemSections();
            _viewModelHomePage.sectionFirstSteps = builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = builderFillData.FillSecondStepSectionData();
            //_viewModelHomePage.sectionThirdSteps = builderFillData.FillSectionPostThirdStepData();
            _viewModelHomePage.sectionSecondSteps = builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionPostSocialVideos = builderFillData.FillSectionPostSocialVideoData();
            return _viewModelHomePage;
        }

        public ViewModelHomePage FillHomapageModelForPostView(int idPost)
        {
            BuilderThemMangaer builderThemMangaer = new BuilderThemMangaer(_db, _viewModelHomePage);
            BuilderFillData builderFillData = new BuilderFillData(_db, _viewModelHomePage);
            _viewModelHomePage.IsActive = builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.checkThemDictionary = builderThemMangaer.CheckThemSections();
            _viewModelHomePage.sectionFirstSteps = builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionPostTop10Steps = builderFillData.FillPostStepSectionTop10Data();
            _viewModelHomePage.sectionPostSteps = builderFillData.FillPostStepSectionDataById(idPost);
            _viewModelHomePage.sectionPostImages = builderFillData.FillSectionPostImageDataById(idPost);
            _viewModelHomePage.sectionPostVideos = builderFillData.FillSectionPostVideoDataById(idPost);
            _viewModelHomePage.sectionPostComments = builderFillData.FillSectionPostCommentDataById(idPost);
            _viewModelHomePage.sectionPostAnswers = builderFillData.FillSectionPostAnswerDataById(idPost);
            _viewModelHomePage.sectionPostSocialVideos = builderFillData.FillSectionPostSocialVideoData();
            return _viewModelHomePage;
        }
        public ViewModelHomePage FillHomapageModelForThirStepView(int idSecondStep)
        {
            BuilderThemMangaer builderThemMangaer = new BuilderThemMangaer(_db, _viewModelHomePage);
            BuilderFillData builderFillData = new BuilderFillData(_db, _viewModelHomePage);
            _viewModelHomePage.IsActive = builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.checkThemDictionary = builderThemMangaer.CheckThemSections();
            _viewModelHomePage.sectionFirstSteps = builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionPostTop10Steps = builderFillData.FillPostStepSectionTop10Data();
            _viewModelHomePage.sectionPostSocialVideos = builderFillData.FillSectionPostSocialVideoData();
            _viewModelHomePage.sectionThirdSteps = builderFillData.FillSectionPostThirdStepData(idSecondStep);
            return _viewModelHomePage;
        }
        public ViewModelHomePage FillHomapageModelForViewSubCategoryPosts(int idThirdStep,int? page)
        {
            BuilderThemMangaer builderThemMangaer = new BuilderThemMangaer(_db, _viewModelHomePage);
            BuilderFillData builderFillData = new BuilderFillData(_db, _viewModelHomePage);
            _viewModelHomePage.IsActive = builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.checkThemDictionary = builderThemMangaer.CheckThemSections();
            _viewModelHomePage.sectionFirstSteps = builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionPostTop10Steps = builderFillData.FillPostStepSectionTop10Data();
            _viewModelHomePage.sectionPostSteps = builderFillData.FillPostStepSectionDataByCategotyId(idThirdStep, page);
            _viewModelHomePage.sectionPostImages = builderFillData.FillSectionPostImageDataByCategoryId(idThirdStep);
            _viewModelHomePage.sectionPostSocialVideos = builderFillData.FillSectionPostSocialVideoData();
            return _viewModelHomePage;
        }

    }
}