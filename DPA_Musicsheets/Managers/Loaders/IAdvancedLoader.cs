using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPA_Musicsheets.Models.Note;


namespace DPA_Musicsheets.Managers.Loaders
{
    interface IAdvancedLoader
    {
        MTrack LoadMidi(String fileName);
        MTrack LoadLily(String fileName);
    }
}
