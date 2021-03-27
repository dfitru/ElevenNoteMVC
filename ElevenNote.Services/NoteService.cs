using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This is how our application interact with the database
namespace ElevenNote.Services
{
   public class NoteService
    {
        private readonly Guid _userId;
        public NoteService (Guid userId)
        {
            _userId = userId;
        }
        public bool CreateNote(NoteCreate model)
        {
            var entity= new Note()
            {
                Owner
            }

        }
    }
}
