using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class Note
    {
        [Key]//specify the property that uniquely identifies an entity or it is the PK of the the database
        public int NoteId { get; set; }
        [Required]// emsure the user  does not enter  null value provides
        public Guid  OwnerId { get; set; }
        [Required]
        [Display(Name="Note Title")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]//limit the amount of characters user can provide
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTimeOffset CreateUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
