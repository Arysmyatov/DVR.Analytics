using DVR.Contracts.Entities;

namespace DVR.Infrastructure.Persistence
{
    public interface ITechnologyCountAnalysisResultRepository
    {
         void AddResult(TechnologyCountAnalysisResult technologyCountAnalysisResult);
         IEnumerable<TechnologyCountAnalysisResult> GetResults();
    }
}