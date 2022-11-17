using System.Collections.Generic;

namespace DVR.Models
{
    public class Vacancy
    {
        public string PositionName { get; set; }
        public string Url { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}