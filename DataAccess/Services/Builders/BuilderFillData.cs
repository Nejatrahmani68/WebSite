using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace DataAccess.Services.Builders
{
    public class BuilderFillData
    {
        private readonly ApplicationDbContext _db;
        private readonly ViewModelHomePage _viewModelHomePage;

        public BuilderFillData(ApplicationDbContext db, ViewModelHomePage viewModelHomePage)
        {
            _db = db;
            _viewModelHomePage = viewModelHomePage;
        }
        public IEnumerable<SectionFirstStep>? FillFirstStepSectionData()
        {
            IEnumerable<SectionFirstStep> fillData = _db.SectionFirstSteps.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionSecondStep>? FillSecondStepSectionData()
        {
            IEnumerable<SectionSecondStep> fillData = _db.SectionSecondSteps.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionThirdStep>? FillThirdStepCategoriesData()
        {
            IEnumerable<SectionThirdStep> fillData = _db.SectionThirdSteps.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(7);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionData()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
       public IEnumerable<SectionPostStep>? FillPostStepSectionTop10MostViewedData()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.ViewsNumber).Take(7);
            return fillData;
        }
        public IEnumerable<SectionPostImage>? FillSectionPostImageData()
        {
            IEnumerable<SectionPostImage> fillData = _db.SectionPostImages.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionPostImage>? FillSectionPostImageDataByModel(IEnumerable<SectionPostStep> postData)
        {
            IEnumerable<SectionPostImage> fillData = _db.SectionPostImages.Where(image => postData.Any(post => post.Id == image.Id_SectionPostStep && image.Active == true && (image.Timable == false || (image.StartDate <= System.DateTime.Now && System.DateTime.Now <= image.EndDate))));
            return fillData;

        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionTop10Data()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(10);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionTop5VideoData()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps.Where(m => m.Active == true && m.SectionPostType!.Title == "Video" && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(5);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionTop5ArticleData()
        {
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps.Where(m => m.Active == true && m.SectionPostType!.Title == "Article" && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(5);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionDataById(int idPost)
        {
            //Add PostViewNumber
            AddViewToPost(idPost);
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps.Where(m => m.Id == idPost && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionDataMostRelatedStepsById(int idPost)
        {
            var Post = _db.SectionPostSteps.Find(idPost);
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps.Where(m => m.Id_SectionThirdStep == Post!.Id_SectionThirdStep && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate).Take(7);
            return fillData;
        }
        public IEnumerable<SectionPostImage>? FillSectionPostImageDataById(int idPost)
        {
            IEnumerable<SectionPostImage> fillData = _db.SectionPostImages.Where(m => m.Id_SectionPostStep == idPost && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionPostVideo>? FillSectionPostVideoDataById(int idPost)
        {
            IEnumerable<SectionPostVideo> fillData = _db.SectionPostVideos.Where(m => m.Id_SectionPostStep == idPost && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).Include(m => m.SectionPostSocialVideo);
            return fillData;
        }
        public IEnumerable<SectionPostCommentStep>? FillSectionPostCommentDataById(int idPost)
        {
            IEnumerable<SectionPostCommentStep> fillData = _db.SectionPostCommentSteps.Include(m => m.SectionPostAnswerSteps).Where(m => m.Id_SectionPostStep == idPost && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionPostAnswerStep>? FillSectionPostAnswerDataById(int idPost)
        {
            IEnumerable<SectionPostAnswerStep> fillData = _db.SectionPostAnswerSteps.Where(m => m.SectionPostCommentStep!.Id_SectionPostStep == idPost && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionPostSocialVideo>? FillSectionPostSocialVideoData()
        {
            IEnumerable<SectionPostSocialVideo> fillData = _db.SectionPostSocialVideos.Where(m => m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        public IEnumerable<SectionThirdStep>? FillSectionPostThirdStepData(int idSecondStep)
        {
            IEnumerable<SectionThirdStep> fillData = _db.SectionThirdSteps.Where(m => m.Id_SectionSecondStep == idSecondStep && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate);
            return fillData;
        }
        public IEnumerable<SectionPostStep>? FillPostStepSectionDataByCategotyId(int idThirdStep, int? page)
        {
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int PageSize = 9;
            IEnumerable<SectionPostStep> fillData = _db.SectionPostSteps.Where(m => m.Id_SectionThirdStep == idThirdStep && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate))).OrderByDescending(m => m.CreateDate);
            return fillData.ToPagedList(pageNumber, PageSize);
        }
        public IEnumerable<SectionPostImage>? FillSectionPostImageDataByCategoryId(int idThirdStep)
        {
            IEnumerable<SectionPostImage> fillData = _db.SectionPostImages.Where(m => m.SectionPostStep!.Id_SectionThirdStep == idThirdStep && m.Active == true && (m.Timable == false || (m.StartDate <= System.DateTime.Now && System.DateTime.Now <= m.EndDate)));
            return fillData;
        }
        //Add PostViewNumber
        public void AddViewToPost(int idPost)
        {
            var Post = _db.SectionPostSteps.Find(idPost);
            Post!.ViewsNumber += 1;
            _db.Update(Post);
            _db.SaveChanges();
        }
    }
}
