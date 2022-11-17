namespace DVR.Contracts.Entities
{
    public class TechnologyCountAnalysisResult
    {
        public DateTime Date { get; set; }
        public IEnumerable<TagGroup> TagGroups { get; set; }
    }
}