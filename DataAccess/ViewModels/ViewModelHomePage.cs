namespace Model.ViewModels
{
    public class ViewModelHomePage
    {
        public bool IsActive { get; set; }
        public string? WebsiteTitle { get; set; }

        public Dictionary<string, bool>? checkThemDictionary { get; set; }
        public IEnumerable<SectionLanguage>? SectionLanguages { get; set; }
        public IEnumerable<SectionFirstStep>? sectionFirstSteps { get; set; }
        public IEnumerable<SectionSecondStep>? sectionSecondSteps { get; set; }
        public IEnumerable<SectionThirdStep>? sectionThirdSteps { get; set; }
        public IEnumerable<SectionThirdStep>? sectionThirdStepCategories { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostSteps { get; set; }
        public IEnumerable<SectionPostImage>? sectionPostImages { get; set; }
        public IEnumerable<SectionPostFile>? sectionPostFiles { get; set; }
        public IEnumerable<SectionPostImage>? sectionPostImagesForVideo { get; set; }
        public IEnumerable<SectionPostImage>? sectionPostImagesForArticl { get; set; }
        public IEnumerable<SectionPostImage>? sectionPostImagesForFile { get; set; }
        public IEnumerable<SectionPostVideo>? sectionPostVideos { get; set; }
        public IEnumerable<SectionPostCommentStep>? sectionPostComments { get; set; }
        public IEnumerable<SectionPostAnswerStep>? sectionPostAnswers { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop10Steps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop10MostViewedSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTopMostRelatedSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop5VideoSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop5FileSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop5ArticleSteps { get; set; }
        public IEnumerable<SectionPostSocialVideo>? sectionPostSocialVideos { get; set; }
    }
}
