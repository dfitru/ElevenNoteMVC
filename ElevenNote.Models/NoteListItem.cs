using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
 //for handling task of collecting property data we wamt the user to eneter specific data and we want to show specific data in specific view
    public class NoteListItem
    {
        public int NoteId  { get; set; }
        public string Title  { get; set; }
        [Display(Name="Created")]// this show up later
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
