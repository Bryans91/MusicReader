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

        private int keycode { get; set; }

        private Duration duration;

        private Boolean point; //if true note duration = duration + half of duration (  duration = 4 + (4/2))


        public Note(Key key, Duration duration)
        {
            this.key = key;
            this.duration = duration;
        }

        public int CalcDurationValue(int baseValue = 1)
        {
            int d = (int)this.duration;
            if (this.point) d += d / 2;

            return baseValue / d;
        }


        public Key Key { get => key; set => key = value; }

        public Duration Duration { get => duration; set => duration = value; }
        public bool Point { get => Point; set => Point = value; }
    }
}
