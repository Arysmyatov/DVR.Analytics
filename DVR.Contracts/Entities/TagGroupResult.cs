namespace DVR.Contracts.Entities
{
    public class TagGroupResult
    {
        public string Name { get; set; }
        public IList<TagResults> TagResults { get; set; }
    }
}