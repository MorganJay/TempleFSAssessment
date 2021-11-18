using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TempleFSAssessment.Data.Entities
{
    [Table("Words")]
    public partial class WordModel
    {
        public WordModel()
        {
            WordDefinitions = new HashSet<WordDefinition>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Key]
        [StringLength(200)]
        public string Word { get; set; }

        [StringLength(200)]
        public string Pronunciation { get; set; }

        public int Definitions { get; set; }

        [InverseProperty(nameof(WordDefinition.WordEntity))]
        public virtual ICollection<WordDefinition> WordDefinitions { get; set; }
    }
}