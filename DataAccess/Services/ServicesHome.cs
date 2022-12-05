using DataAccess.Services.Builders;
using Model.ViewModels;

namespace DataAccess.Services
{
    public class ServicesHome
    {
        private readonly ViewModelHomePage _viewModelHomePage;
        private readonly BuilderThemMangaer _builderThemMangaer;
        private readonly BuilderFillData _builderFillData;

        public ServicesHome(ViewModelHomePage viewModelHomePage, BuilderThemMangaer builderThemMangaer, BuilderFillData builderFillData)
        {
            _viewModelHomePage = viewModelHomePage;
            _builderThemMangaer = builderThemMangaer;  
            _builderFillData = builderFillData;
        }
        //Fill ViewModel For Home/Index
        public ViewModelHomePage FillHomapageModel()
        {
            _viewModelHomePage.IsActive = _builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.WebsiteTitle = _builderFillData.FillWebSiteTitleData();
            _viewModelHomePage.checkThemDictionary = _builderThemMangaer.CheckThemSections();
            _viewModelHomePage.SectionLanguages = _builderFillData.FillSectionLanguagesSectionData();
            _viewModelHomePage.sectionFirstSteps = _builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = _builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionThirdStepCategories = _builderFillData.FillThirdStepCategoriesData();
            _viewModelHomePage.sectionPostTop10Steps = _builderFillData.FillPostStepSectionTop10Data();
            _viewModelHomePage.sectionPostTop10MostViewedSteps = _builderFillData.FillPostStepSectionTop10MostViewedData();
            _viewModelHomePage.sectionPostTop5ArticleSteps = _builderFillData.FillPostStepSectionTop5ArticleData();
            _viewModelHomePage.sectionPostTop5VideoSteps = _builderFillData.FillPostStepSectionTop5VideoData();
            _viewModelHomePage.sectionPostTop5FileSteps = _builderFillData.FillPostStepSectionTop5FileData();
            _viewModelHomePage.sectionPostImagesForVideo = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5VideoSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForArticl = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5ArticleSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForFile = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5FileSteps!.ToList());
            _viewModelHomePage.sectionPostSocialVideos = _builderFillData.FillSectionPostSocialVideoData();
            return _viewModelHomePage;
        }
        //Fill ViewModel For Home/PostView
        public ViewModelHomePage FillHomapageModelForPostView(int idPost)
        {
            _viewModelHomePage.IsActive = _builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.WebsiteTitle = _builderFillData.FillWebSiteTitleData();
            _viewModelHomePage.checkThemDictionary = _builderThemMangaer.CheckThemSections();
            _viewModelHomePage.SectionLanguages = _builderFillData.FillSectionLanguagesSectionData();
            _viewModelHomePage.sectionFirstSteps = _builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = _builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionPostTop10Steps = _builderFillData.FillPostStepSectionTop10Data();
            _viewModelHomePage.sectionPostSteps = _builderFillData.FillPostStepSectionDataById(idPost);
            _viewModelHomePage.sectionPostTopMostRelatedSteps = _builderFillData.FillPostStepSectionDataMostRelatedStepsById(idPost);
            _viewModelHomePage.sectionPostImages = _builderFillData.FillSectionPostImageDataById(idPost);
            _viewModelHomePage.sectionPostVideos = _builderFillData.FillSectionPostVideoDataById(idPost);
            _viewModelHomePage.sectionPostFiles = _builderFillData.FillSectionPostFileDataById(idPost);
            _viewModelHomePage.sectionPostComments = _builderFillData.FillSectionPostCommentDataById(idPost);
            _viewModelHomePage.sectionPostAnswers = _builderFillData.FillSectionPostAnswerDataById(idPost);
            _viewModelHomePage.sectionPostTop5ArticleSteps = _builderFillData.FillPostStepSectionTop5ArticleData();
            _viewModelHomePage.sectionPostTop5VideoSteps = _builderFillData.FillPostStepSectionTop5VideoData();
            _viewModelHomePage.sectionPostTop5FileSteps = _builderFillData.FillPostStepSectionTop5FileData();
            _viewModelHomePage.sectionPostImagesForVideo = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5VideoSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForArticl = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5ArticleSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForFile = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5FileSteps!.ToList());
            _viewModelHomePage.sectionPostSocialVideos = _builderFillData.FillSectionPostSocialVideoData();
            return _viewModelHomePage;
        }
        //Fill ViewModel For Home/SectionThirdStepView
        public ViewModelHomePage FillHomapageModelForThirStepView(int idSecondStep)
        {
            _viewModelHomePage.IsActive = _builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.WebsiteTitle = _builderFillData.FillWebSiteTitleData();
            _viewModelHomePage.checkThemDictionary = _builderThemMangaer.CheckThemSections();
            _viewModelHomePage.SectionLanguages = _builderFillData.FillSectionLanguagesSectionData();
            _viewModelHomePage.sectionFirstSteps = _builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = _builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionPostTop10Steps = _builderFillData.FillPostStepSectionTop10Data();
            _viewModelHomePage.sectionPostSocialVideos = _builderFillData.FillSectionPostSocialVideoData();
            _viewModelHomePage.sectionThirdSteps = _builderFillData.FillSectionPostThirdStepData(idSecondStep);
            _viewModelHomePage.sectionPostTop5ArticleSteps = _builderFillData.FillPostStepSectionTop5ArticleData();
            _viewModelHomePage.sectionPostTop5VideoSteps = _builderFillData.FillPostStepSectionTop5VideoData();
            _viewModelHomePage.sectionPostTop5FileSteps = _builderFillData.FillPostStepSectionTop5FileData();
            _viewModelHomePage.sectionPostImagesForVideo = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5VideoSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForArticl = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5ArticleSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForFile = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5FileSteps!.ToList());
            return _viewModelHomePage;
        }
        //Fill ViewModel For Home/PostsCategoryView
        public ViewModelHomePage FillHomapageModelForViewSubCategoryPosts(int idThirdStep,int? page)
        {
            _viewModelHomePage.IsActive = _builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.WebsiteTitle = _builderFillData.FillWebSiteTitleData();
            _viewModelHomePage.checkThemDictionary = _builderThemMangaer.CheckThemSections();
            _viewModelHomePage.SectionLanguages = _builderFillData.FillSectionLanguagesSectionData();
            _viewModelHomePage.sectionFirstSteps = _builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = _builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionPostTop10Steps = _builderFillData.FillPostStepSectionTop10Data();
            _viewModelHomePage.sectionPostSteps = _builderFillData.FillPostStepSectionDataByCategotyId(idThirdStep, page);
            _viewModelHomePage.sectionPostImages = _builderFillData.FillSectionPostImageDataByCategoryId(idThirdStep);
            _viewModelHomePage.sectionPostSocialVideos = _builderFillData.FillSectionPostSocialVideoData();
            _viewModelHomePage.sectionPostTop5ArticleSteps = _builderFillData.FillPostStepSectionTop5ArticleData();
            _viewModelHomePage.sectionPostTop5VideoSteps = _builderFillData.FillPostStepSectionTop5VideoData();
            _viewModelHomePage.sectionPostTop5FileSteps = _builderFillData.FillPostStepSectionTop5FileData();
            _viewModelHomePage.sectionPostImagesForVideo = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5VideoSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForArticl = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5ArticleSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForFile = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5FileSteps!.ToList());
            return _viewModelHomePage;
        }

        //Fill ViewModel For Home/ViewAllPostInfinitScroll
        public ViewModelHomePage FillHomapageModelForViewAllPostInfinitScroll(int? page)
        {
            _viewModelHomePage.IsActive = _builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.WebsiteTitle = _builderFillData.FillWebSiteTitleData();
            _viewModelHomePage.checkThemDictionary = _builderThemMangaer.CheckThemSections();
            _viewModelHomePage.SectionLanguages = _builderFillData.FillSectionLanguagesSectionData();
            _viewModelHomePage.sectionFirstSteps = _builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = _builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionPostTop10Steps = _builderFillData.FillPostStepSectionTop10Data();
            _viewModelHomePage.sectionPostSteps = _builderFillData.FillPostStepSectionDataForInfiniteScroll(page);
            _viewModelHomePage.sectionPostImages = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostSteps!.ToList());
            _viewModelHomePage.sectionPostSocialVideos = _builderFillData.FillSectionPostSocialVideoData();
            _viewModelHomePage.sectionPostTop5ArticleSteps = _builderFillData.FillPostStepSectionTop5ArticleData();
            _viewModelHomePage.sectionPostTop5VideoSteps = _builderFillData.FillPostStepSectionTop5VideoData();
            _viewModelHomePage.sectionPostTop5FileSteps = _builderFillData.FillPostStepSectionTop5FileData();
            _viewModelHomePage.sectionPostImagesForVideo = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5VideoSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForArticl = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5ArticleSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForFile = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5FileSteps!.ToList());
            return _viewModelHomePage;
        }
        public ViewModelHomePage FillHomapageModelForViewAllPostOrderedByType(string postType,int? page)
        {
            _viewModelHomePage.IsActive = _builderThemMangaer.CheckActiveTime();
            _viewModelHomePage.WebsiteTitle = _builderFillData.FillWebSiteTitleData();
            _viewModelHomePage.checkThemDictionary = _builderThemMangaer.CheckThemSections();
            _viewModelHomePage.SectionLanguages = _builderFillData.FillSectionLanguagesSectionData();
            _viewModelHomePage.sectionFirstSteps = _builderFillData.FillFirstStepSectionData();
            _viewModelHomePage.sectionSecondSteps = _builderFillData.FillSecondStepSectionData();
            _viewModelHomePage.sectionPostTop10Steps = _builderFillData.FillPostStepSectionTop10Data();
            _viewModelHomePage.sectionPostSteps = _builderFillData.FillPostStepSectionDataOrderedByType(postType,page);
            _viewModelHomePage.sectionPostImages = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostSteps!.ToList());
            _viewModelHomePage.sectionPostSocialVideos = _builderFillData.FillSectionPostSocialVideoData();
            _viewModelHomePage.sectionPostTop5ArticleSteps = _builderFillData.FillPostStepSectionTop5ArticleData();
            _viewModelHomePage.sectionPostTop5VideoSteps = _builderFillData.FillPostStepSectionTop5VideoData();
            _viewModelHomePage.sectionPostTop5FileSteps = _builderFillData.FillPostStepSectionTop5FileData();
            _viewModelHomePage.sectionPostImagesForVideo = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5VideoSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForArticl = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5ArticleSteps!.ToList());
            _viewModelHomePage.sectionPostImagesForFile = _builderFillData.FillSectionPostImageDataByModel(_viewModelHomePage!.sectionPostTop5FileSteps!.ToList());
            return _viewModelHomePage;
        }
    }
}