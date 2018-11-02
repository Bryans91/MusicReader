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

        public Note CreateNote(Key key, Duration duration)
        {
            //use this create for possible extra steps

            return new Note(key, duration);
        }

        public Note CreateNote(string key, int duration)
        {
            Duration mDuration = Symbols.GetDuration(duration);
            Key mKey = Symbols.GetKey(key);

            return this.CreateNote(mKey, mDuration);
        }

        public Note CreateNote(string key)
        {
          
            Key mKey = Symbols.GetKey(key);
            Duration mDuration = Symbols.GetDuration(1);

            return this.CreateNote(mKey, mDuration);
        }

        public Note CreateNote(Key key, int duration)
        {
            Duration mDuration = Symbols.GetDuration(duration);
            return this.CreateNote(key, mDuration);
        }




    }
}
