using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPA_Musicsheets.Utility;

namespace DPA_Musicsheets.Models.Note
{
    public sealed class NoteFactory
    {
        private static readonly NoteFactory instance = new NoteFactory();

      

        private NoteFactory()
        {
         
        }

      
        public static NoteFactory Instance
        {
            get
            {
                return instance;
            }
        }


        public Note CreateNote(string key, int duration)
        {
            Duration mDuration = Symbols.GetDuration(duration);
            Key mKey = Symbols.GetKey(key);

            return new Note(mKey, mDuration);
        }

        public Note CreateNote(string key)
        {
          
            Key mKey = Symbols.GetKey(key);

            return new Note(mKey);
        }




    }
}
