using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Models.Note
{
    public class Note
    {

        private Key key;

        private Duration duration;

        public Note(Key key, Duration duration)
        {
            this.key = key;
            this.duration = duration;
        }

        public Note(Key key)
        {
            this.key = key;
            this.duration = Duration.Whole;
        }


        public Key Key { get => key; set => key = value; }

        public Duration Duration { get => duration; set => duration = value; }
    }
}
