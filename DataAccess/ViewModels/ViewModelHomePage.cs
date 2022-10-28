namespace Model.ViewModels
{
    public class ViewModelHomePage
    {
        public bool IsActive { get; set; }
        public Dictionary<string, bool>? checkThemDictionary { get; set; }
        public IEnumerable<SectionFirstStep>? sectionFirstSteps { get; set; }
        public IEnumerable<SectionSecondStep>? sectionSecondSteps { get; set; }
        public IEnumerable<SectionThirdStep>? sectionThirdSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostSteps { get; set; }
        public IEnumerable<SectionPostStep>? sectionPostTop10Steps { get; set; }
        public IEnumerable<SectionPostImage>? sectionPostImages { get; set; }

    }
}
