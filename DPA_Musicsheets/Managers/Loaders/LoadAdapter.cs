using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Managers.Loaders
{
    class LoadAdapter : ILoader
    {
        IAdvancedLoader loader;

        public LoadAdapter(string fileName)
        {
            string ext = Path.GetExtension(fileName);

            switch (ext)
            {
                case ".mid":
                    this.loader = new MidiLoader();
                    break;
                case ".ly":
                    this.loader = new LilypondLoader();
                    break;
                default:
                    throw new NotSupportedException($"File extension {Path.GetExtension(fileName)} is not supported.");
            }
        }

        public void LoadFile(string fileName)
        {
            string ext = Path.GetExtension(fileName);

            switch (ext)
            {
                case ".mid":
                    this.loader.LoadMidi(fileName);
                    break;
                case ".ly":
                    this.loader.LoadLily(fileName);
                    break;
                default:
                    throw new Exception("Something went wrong loading the " + ext + " file");
            }

        }
    }
}
