using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleFSAssessment.Data.Entities
{
    [Table("WordDefinitions")]
    public partial class WordDefinition
    {
        [Key]
        public int Id { get; set; }

        public string Word { get; set; }
        public string Type { get; set; }
        public string Definition { get; set; }
        public string Example { get; set; }
        public string Image_url { get; set; }
        public string Emoji { get; set; }

        [ForeignKey(nameof(Word))]
        [InverseProperty(nameof(WordModel.WordDefinitions))]
        public virtual WordModel WordEntity { get; set; }
    }
}