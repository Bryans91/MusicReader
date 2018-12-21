using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Models.Note
{
    class MTrack
    {
        //has a linked list of bars
        //has a name
        //Tempo
        //Maatsoort
        private string Name { get; set; }
        private Bar FirstBar { get; set; }

        private int Tempo { get; set; }
    
        public MTrack(string name)
        {
            this.Name = name;
        }

    }
}
