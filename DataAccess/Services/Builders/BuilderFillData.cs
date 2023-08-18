using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Model;
using System.Globalization;
using X.PagedList;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess.Services.Builders
{
    public class BuilderFillData
    {
        private readonly ApplicationDbContext _db;
        public BuilderFillData(ApplicationDbContext db)
        {
            _db = db;
        }

        //WebSiteTitle
        public string? FillWebSiteTitleData()
        {
            string fillData = _db.WebsiteActiveTimeControls!.Find(1)!.WebsiteTitle!;
            return fillData;
        }

        //LanguageFillData
        public IEnumerable<SectionLanguage>? FillSectionLanguagesSectionData()
        {
            IEnumerable<SectionLanguage> fillData = _db.SectionLanguages!.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        //FirstStepFillData
        public IEnumerable<SectionFirstStep>? FillFirstStepSectionData()
        {
            IEnumerable<SectionFirstStep> fillData = _db.SectionFirstSteps!.Where(m => m.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }

        //SecondStepFillData
        public IEnumerable<SectionSecondStep>? FillSecondStepSectionData()
        {
            IEnumerable<SectionSecondStep> fillData = _db.SectionSecondSteps!.Where(m => m.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }

        //ThirdStepFillData
        public IEnumerable<SectionThirdStep>? FillThirdStepCategoriesData()
        {
            IEnumerable<SectionThirdStep> fillData = _db.SectionThirdSteps!.Where(m => m.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(7);
            return fillData;
        }

        public IEnumerable<SectionThirdStep>? FillSectionPostThirdStepData(int idSecondStep)
        {
            IEnumerable<SectionThirdStep> fillData = _db.SectionThirdSteps!.Where(m => m.Id_SectionSecondStep == idSecondStep && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate);
            return fillData;
        }

        //PostStepFillData
        public IEnumerable<SectionPostStep>? FillPostStepSectionData()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionTop7MostViewedData()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.ViewsNumber).Take(7);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionTop12Data()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(12);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionTop5LastMonthData()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.CreateDate >= DateTime.Now.AddDays(-30) && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.ViewsNumber).Take(5);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionTop5VideoData()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && m.SectionPostType!.Title == "Video" && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(5);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionTop5ArticleData()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && m.SectionPostType!.Title == "Article" && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(5);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionTop5FileData()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && m.SectionPostType!.Title == "File" && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(5);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionDataById(int idPost)
        {
            //Add PostViewNumber
            AddViewToPost(idPost);
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.Id == idPost && m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionDataMostRelatedStepsById(int idPost)
        {
            var Post = _db.SectionPostSteps!.Find(idPost);
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps.Where(m => m.Id_SectionThirdStep == Post!.Id_SectionThirdStep && m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(7);
            return fillData;
        }
        //PagingPosts
        public IEnumerable<SectionPostStep>? FillPostStepSectionDataByCategotyId(int idThirdStep, int? page)
        {
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int PageSize = 9;
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.Id_SectionThirdStep == idThirdStep && m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate);
            return fillData.ToPagedList(pageNumber, PageSize);
        }
        //Searched Posts
        public IEnumerable<SectionPostStep>? FillPostStepSectionDataBySearch(string searchtxt, int? page)
        {
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int PageSize = 9;
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => (m.Title!.Contains(searchtxt) || m.ShortDescription!.Contains(searchtxt) || m.FullDescription!.Contains(searchtxt) || m.WriterName!.Contains(searchtxt) || m.TagsName!.Contains(searchtxt)) && m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate);
            return fillData.ToPagedList(pageNumber, PageSize);
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionDataForInfiniteScroll(int? page)
        {
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int PageSize = 27;
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate);
            return fillData.ToPagedList(pageNumber, PageSize);
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionDataOrderedByType(string postType, int? page)
        {
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int PageSize = 27;
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps!.Where(m => m.SectionThirdStep!.SectionSecondStep!.SectionFirstStep!.SectionLanguage!.Name == CultureInfo.CurrentCulture.Name && m.SectionPostType!.Title == postType && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate);
            return fillData.ToPagedList(pageNumber, PageSize);
        }
        //Add PostViewNumber
        public void AddViewToPost(int idPost)
        {
            var Post = _db.SectionPostSteps!.Find(idPost);
            Post!.ViewsNumber += 1;
            _db.Update(Post);
            _db.SaveChanges();
        }

        //ImageStepFillData
        public IEnumerable<SectionPostImage>? FillSectionPostImageData()
        {
            IEnumerable<SectionPostImage> fillData = _db.SectionPostImages!.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public List<SectionPostImage>? FillSectionPostImageDataByModel(List<SectionPostStep> postData)
        {
            List<SectionPostImage> fillData = new();
            foreach (var item in postData)
            {
                fillData.AddRange(_db.SectionPostImages!.Where(image => image.Id_SectionPostStep == item.Id && image.Active == true && (image.Timable == false || (image.StartDate <= System.DateTime.Now && System.DateTime.Now <= image.EndDate))));
            }
            return fillData;

        }
        public IEnumerable<SectionPostImage>? FillSectionPostImageDataById(int idPost)
        {
            IEnumerable<SectionPostImage> fillData = _db.SectionPostImages!.Where(m => m.Id_SectionPostStep == idPost && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionPostImage>? FillSectionPostImageDataByCategoryId(int idThirdStep)
        {
            IEnumerable<SectionPostImage> fillData = _db.SectionPostImages!.Where(m => m.SectionPostStep!.Id_SectionThirdStep == idThirdStep && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }

        //VideoStepFillData
        public IEnumerable<ArmyMembersAccounts>? FillSectionPostVideoDataById(int idPost)
        {
            IEnumerable<ArmyMembersAccounts> fillData = _db.SectionPostVideos!.Where(m => m.Id_SectionPostStep == idPost && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).Include(m => m.SectionPostSocialVideo);
            return fillData;
        }

        //FileStepFillData
        public IEnumerable<SectionPostFile>? FillSectionPostFileDataById(int idPost)
        {
            IEnumerable<SectionPostFile> fillData = _db.SectionPostFiles!.Where(m => m.Id_SectionPostStep == idPost && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }

        //CommentStepFillData
        public IEnumerable<SectionPostCommentStep>? FillSectionPostCommentDataById(int idPost)
        {
            IEnumerable<SectionPostCommentStep> fillData = _db.SectionPostCommentSteps!.Include(m => m.SectionPostAnswerSteps).Where(m => m.Id_SectionPostStep == idPost && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }

        //AnswerStepFillData
        public IEnumerable<SectionPostAnswerStep>? FillSectionPostAnswerDataById(int idPost)
        {
            IEnumerable<SectionPostAnswerStep> fillData = _db.SectionPostAnswerSteps!.Where(m => m.SectionPostCommentStep!.Id_SectionPostStep == idPost && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }

        //SocialVideoStepFillData
        public IEnumerable<SectionPostSocialVideo>? FillSectionPostSocialVideoData()
        {
            IEnumerable<SectionPostSocialVideo> fillData = _db.SectionPostSocialVideos!.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }

    }
}
