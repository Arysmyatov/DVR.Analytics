namespace DVR.Contracts.Entities
{
    public class TagResults : Tag
    {
        public IList<TagResult> Results { get; set; }
    }
}