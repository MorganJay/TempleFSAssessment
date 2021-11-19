using System.Collections.Generic;

namespace TempleFSAssessment.DTOs
{
    public class WordDTO
    {
        public string Pronunciation { get; set; }
        public List<WordDefinitionDTO> Definitions { get; set; }
        public string Word { get; set; }
    }

    public class WordDefinitionDTO
    {
        public string Type { get; set; }
        public string Definition { get; set; }
        public string Example { get; set; }
        public string Image_url { get; set; }
        public string Emoji { get; set; }
    }
}