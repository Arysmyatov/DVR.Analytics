using DVR.Contracts.Entities;
using DVR.Infrastructure.Services;

namespace DVR.Infrastructure.Persistence
{
    public class TechnologyCountAnalysisResultRepository : ITechnologyCountAnalysisResultRepository
    {
        private readonly XmlContext context;
        private readonly IList<TechnologyCountAnalysisResult> technologyCountAnalysisResults;

        public TechnologyCountAnalysisResultRepository(XmlContext context){
            this.context = context;
            technologyCountAnalysisResults = this.context.TechnologyCountAnalysisResults.ToList();
        }


        public IEnumerable<TechnologyCountAnalysisResult> GetResults()
        {
            return technologyCountAnalysisResults;
        }


        public void AddResult(TechnologyCountAnalysisResult technologyCountAnalysisResult)
        {
            technologyCountAnalysisResults.Add(technologyCountAnalysisResult);
            context.TechnologyCountAnalysisResults = technologyCountAnalysisResults;
            context.UpdateTechnologyCountAnalysisResults();
        }
    }
}