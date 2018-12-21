using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanford.Multimedia.Midi;

namespace DPA_Musicsheets.Managers.Loaders.Strategy
{
    static class StrategyList
    {

        public static Dictionary<MetaType, IStrategy> MetaMap = new Dictionary<MetaType, IStrategy>
        {
            { MetaType.TimeSignature, new TimeSignatureStrategy() },
            { MetaType.Tempo, new TempoStrategy() },
            { MetaType.EndOfTrack, new EndOfTrackStrategy() },
        };
    }
}
