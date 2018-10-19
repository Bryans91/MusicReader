using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public Note createNote(string key, string length)
        {
           


        }




    }
}
