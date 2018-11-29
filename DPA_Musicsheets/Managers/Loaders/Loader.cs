using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Managers.Loaders
{
    class Loader : ILoader
    {
        LoadAdapter adapter;

        public string LoadFile(string fileName)
        {
            adapter = new LoadAdapter(fileName);

            return adapter.LoadFile(fileName);
        }
    }
}
