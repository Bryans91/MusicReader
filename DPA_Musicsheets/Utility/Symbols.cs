using DPA_Musicsheets.Models.Note;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Utility
{
    public static class Symbols
    {
        private static readonly Dictionary<string, Key> keyMap = new Dictionary<string, Key>
        {
            { "C", Key.C },
            { "C#", Key.CSharp},
            { "D", Key.D },
            { "D#", Key.DSharp },
            { "E", Key.E },
            { "F", Key.F },
            { "F#",  Key.FSharp },
            { "G", Key.G },
            { "G#", Key.GSharp },
            { "A", Key.A },
            { "A#", Key.ASharp },
            { "B", Key.B },
            { "", Key.None},
            { "R", Key.Rest }

        };

        private static readonly Dictionary<int, Duration> durationMap = new Dictionary<int, Duration>
        {
            { 1, Duration.Whole },
            { 2, Duration.Half },
            { 4, Duration.Quarter },
            { 8, Duration.Sixteenth },


        };

        public static Key GetKey(string key)
        {
            if (keyMap.ContainsKey(key))
            {
                return keyMap[key];
            }
            return Key.None;
        }

        public static Duration GetDuration(int key)
        {
            if (durationMap.ContainsKey(key))
            {
                return durationMap[key];
            }
            return Duration.Whole;
        }



    }
}
