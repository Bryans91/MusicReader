using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Models.Note
{
    class Note
    {

        private Key key;

        private Duration duration;


        public Key Key { get => key; set => key = value; }

        public Duration Duration { get => duration; set => duration = value; }
    }
}
