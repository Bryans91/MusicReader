using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Managers.Loaders
{
    interface IAdvancedLoader
    {
        String LoadMidi(String fileName);
        String LoadLily(String fileName);
    }
}
