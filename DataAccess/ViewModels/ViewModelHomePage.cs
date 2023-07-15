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
        public IEnumerable<ArmyMembersAccounts>? sectionPostVideos { get; set; }
        public IEnumerable<SectionPostCommentStep>? sectionPostComments { get; set; }
        public IEnumerable<SectionPostAnswerStep>? sectionPostAnswers { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop12Steps { get; set; }
        public IEnumerable<SectionPostImage>? sectionPostImageTop12Steps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop5LastMonthSteps { get; set; }
        public IEnumerable<SectionPostImage>? sectionPostImageTop5LastMonthSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop7MostViewedSteps { get; set; }
        public IEnumerable<SectionPostImage>? sectionPostImageTop7MostViewedSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTopMostRelatedSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop5VideoSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop5FileSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop5ArticleSteps { get; set; }
        public IEnumerable<SectionPostSocialVideo>? sectionPostSocialVideos { get; set; }
    }
}
