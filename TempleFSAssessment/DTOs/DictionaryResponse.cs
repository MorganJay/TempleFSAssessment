using System.Collections.Generic;

namespace TempleFSAssessment
{
    public class DefinitionDTO
    {
        public string Type { get; set; }
        public string Definition { get; set; }
        public string Example { get; set; }
        public string Image_url { get; set; }
        public string Emoji { get; set; }
    }

    public class SearchResponse
    {
        public string Pronunciation { get; set; }
        public List<DefinitionDTO> Definitions { get; set; }
        public string Word { get; set; }
    }
}