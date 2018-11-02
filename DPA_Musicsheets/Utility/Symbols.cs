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
        private static readonly Dictionary<string, Key> KeyMap = new Dictionary<string, Key>
        {
            { "C", Key.C },
            { "C#", Key.CSharp},
            { "Db", Key.DFlat },
            { "D", Key.D },
            { "D#", Key.DSharp },
            { "Eb", Key.EFlat },
            { "E", Key.E },
            { "F", Key.F },
            { "F#",  Key.FSharp },
            { "Gb", Key.GFlat },
            { "G", Key.G },
            { "G#", Key.GSharp },
            { "Ab", Key.AFlat },
            { "A", Key.A },
            { "A#", Key.ASharp },
            { "Bb", Key.BFlat },
            { "B", Key.B },
            { "", Key.None},
            { "R", Key.Rest }

        };

        private static readonly Dictionary<int, Duration> DurationMap = new Dictionary<int, Duration>
        {
            { 1, Duration.Whole },
            { 2, Duration.Half },
            { 4, Duration.Quarter },
            { 8, Duration.Eighth },
            { 16, Duration.Sixteenth },
        };

        public static Key GetKey(string key)
        {
            if (KeyMap.ContainsKey(key))
            {
                return KeyMap[key];
            }
            return Key.None;
        }

        public static String GetKeyString(Key key)
        {
            return KeyMap.FirstOrDefault(x => x.Value == key).Key;
        }

        public static Duration GetDuration(int key)
        {
            if (DurationMap.ContainsKey(key))
            {
                return DurationMap[key];
            }
            return Duration.Whole;
        }



    }
}
