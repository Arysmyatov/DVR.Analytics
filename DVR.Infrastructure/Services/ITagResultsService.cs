using DVR.Contracts.Entities;

namespace DVR.Infrastructure.Services
{
    public interface ITagResultsService
    {
        string RootPath { get; set; }
        IEnumerable<TagGroupResult> GetResults();
    }
}